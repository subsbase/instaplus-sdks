using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Instaplus.Net.Models;
using Instaplus.Net.Requests;
using Instaplus.Net.Utils;

namespace Instaplus.Net;

public class InstaplusApi
{
    private readonly (string UserId, string Password) _creds;
    private readonly HttpClient _httpClient;
    private readonly InstaplusApiOptions _options = new();

    private string? _token;
    private DateTime _tokenExpiry = DateTime.MinValue;
    public InstaplusApi(string userId, string password, Action<InstaplusApiOptions>? setupActions = null)
    {
        setupActions?.Invoke(_options);

        if (_options.HttpClientFactory == null)
        {
            _httpClient = new HttpClient();    
        }
        else
        {
            _httpClient = _options.HttpClientFactory.CreateClient();
        }
        _httpClient.BaseAddress = new Uri(_options.BaseUrl);
        
        _creds = (userId, password);
    }
    
    public async Task<Order?> GetOrder(string orderId)
    {
        var order = await GetAsync($"/order/{orderId}",new
        {
            Id = "",
            ExternalId = "",
            CreatedAt = new DateTime(),
            ExpiresAt = new DateTime(),
            Amount = 0m,
            CollectedAmount = 0m,
            To = new object(),
            ReceivingAccountId = "",
            ReceivingAccountType = "",
            Notes ="",
            TransactionReceipts = new []
            {
                new
                {
                    InstapayReference = "",
                    Timestamp = new DateTime(),
                    Amount = 0m,
                    From = new
                    {
                        IPA = "",
                        Link = ""
                    }
                }
            }
        });
        
        if(order == null)
        {
            return null;
        }

        return new Order()
        {
            Id = order.Id,
            ExternalId = order.ExternalId,
            CreatedAt = order.CreatedAt,
            ExpiresAtUtc = order.ExpiresAt,
            Amount = order.Amount,
            CollectedAmount = order.CollectedAmount,
            Notes = order.Notes,
            To = JsonSerializer.Serialize(order.To),
            ReceivingAccountId = order.ReceivingAccountId,
            ReceivingAccountType = Enum.Parse<ReceivingAccountType>(order.ReceivingAccountType, true),
            
            TransactionReceipts = order.TransactionReceipts?.Select(t => new TransactionReceipt()
            {
                InstapayReference = t.InstapayReference,
                Timestamp = t.Timestamp,
                From = new ReceivingAccountInfo.InstaPay() {IPA = t.From.IPA, Link = t.From.Link},
                Amount = t.Amount,
            }).ToList()
        };
    }

    public async Task<GroupOrder?> GetGroupOrder(string groupId)
    {
        var groupOrder = await GetAsync($"/group-order/{groupId}", new
        {
            Id  = "",
            TotalAmount = 0m,
            CollectedAmount = 0m,
            CreatedAt = new DateTime(),
            ExpiresAt = new DateTime(),
            To = new object(),
            ReceivingAccountId = "",
            ReceivingAccountType = "",
            Notes = "",
            Orders = new []
            {
                new
                {
                    OrderId = "",
                    TotalAmount = 0m,
                    CollectedAmount = 0m,
                    ExternalId = ""
                }
            }
        });

        if (groupOrder == null)
        {
            return null;
        }
        return new GroupOrder()
        {
            Id = groupOrder.Id,
            TotalAmount = groupOrder.TotalAmount,
            CollectedAmount = groupOrder.CollectedAmount,
            CreatedAt = groupOrder.CreatedAt,
            ExpiresAt = groupOrder.ExpiresAt,
            
            To = JsonSerializer.Serialize(groupOrder.To),
            
            ReceivingAccountId = groupOrder.ReceivingAccountId,
            ReceivingAccountType = Enum.Parse<ReceivingAccountType>(groupOrder.ReceivingAccountType, true),
            Notes = groupOrder.Notes,
            
            Orders = groupOrder.Orders.Select( o => new GroupOrder.Order()
            {
                Id = o.OrderId,
                Amount = o.TotalAmount,
                CollectedAmount = o.CollectedAmount,
                ExternalId = o.ExternalId
            }).ToList()
            
        };
    }

    public async Task<string?> CreateOrder(NewOrder newOrder)
    {
        await Login();
        return await AuthorizedPutAsync("/order", newOrder, string.Empty);
    }

    public async Task<string?> CreateGroupOrder(NewGroupOrder newGroupOrder)
    {
        await Login();
        return await AuthorizedPutAsync("/group-order", newGroupOrder, string.Empty);
    }
    
    public bool IsValidSignature(string payload, string secret, string signature)
    {
        var keyBytes = Encoding.UTF8.GetBytes(secret);
        using HMACSHA256 hmacsha256 = new(keyBytes);
        var hashBytes = hmacsha256.ComputeHash(Encoding.UTF8.GetBytes(payload));
        var computed = string.Concat(hashBytes.Select(b => b.ToString("x2")));
        return computed == signature; 
    }


    private async Task Login()
    {
        if (_tokenExpiry > DateTime.UtcNow)
        {
            return;
        }
        
        var response = await PostAsync($"/user/login", 
            new {
            userId = _creds.UserId,
            password = _creds.Password
        }, 
            new { Token = "", ExpiryDate = new DateTime() });

        if (response is null)
        {
            throw new InstaplusApiException("Failed to login");
        }
        _token = response.Token;
        _tokenExpiry = response.ExpiryDate;
    }
    private async Task<TSuccessResponse?> PostAsync<TPayload, TSuccessResponse>(string url, TPayload payload, TSuccessResponse successResponse)
    {
        var serialized = JsonSerializer.Serialize(payload, JsonSerializerOptionsUtils.DefaultJsonSerializerOptions);
        var content = new StringContent(serialized, Encoding.UTF8, "application/json");

        var retryPolicy = PollyUtils.GetRetryPolicy();
        
        var response = await retryPolicy.ExecuteAsync( async () =>
            await _httpClient.PostAsync(url, content));

        if (response.IsSuccessStatusCode)
        {
            return await JsonSerializer.DeserializeAsync<TSuccessResponse>(
                await response.Content.ReadAsStreamAsync(), JsonSerializerOptionsUtils.DefaultJsonSerializerOptions
                );
        }

        throw new InstaplusApiException($"API Call Failed: {(int)response.StatusCode}:{response.ReasonPhrase} \n\r  {await response.Content.ReadAsStringAsync()}");
    }
    
    private async Task<TSuccessResponse?> GetAsync<TSuccessResponse>(string url, TSuccessResponse successResponse)
    {
       var retryPolicy = PollyUtils.GetRetryPolicy();
        
        var response = await retryPolicy.ExecuteAsync( async () =>
            await _httpClient.GetAsync(url));

        if (response.IsSuccessStatusCode)
        {
            return await JsonSerializer.DeserializeAsync<TSuccessResponse>(
                await response.Content.ReadAsStreamAsync(), JsonSerializerOptionsUtils.DefaultJsonSerializerOptions
                );
        }

        throw new InstaplusApiException($"API Call Failed: {(int)response.StatusCode}:{response.ReasonPhrase} \n\r  {await response.Content.ReadAsStringAsync()}");
    }
    
    private async Task<TSuccessResponse?> AuthorizedPutAsync<TPayload, TSuccessResponse>(string url, TPayload payload, TSuccessResponse successResponse)
        where TSuccessResponse : class
    {
        var serialized = JsonSerializer.Serialize(payload,JsonSerializerOptionsUtils.DefaultJsonSerializerOptions);
        var content = new StringContent(serialized, Encoding.UTF8, "application/json");

        var retryPolicy = PollyUtils.GetRetryPolicy();

        var response = await retryPolicy.ExecuteAsync(async () =>
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "Bearer", _token);
            return await _httpClient.PutAsync(url, content);
        });
        
        if (response.IsSuccessStatusCode)
        {
            return typeof(TSuccessResponse) == typeof(string)
                ? await response.Content.ReadAsStringAsync() as TSuccessResponse
                : await JsonSerializer.DeserializeAsync<TSuccessResponse>(
                    await response.Content.ReadAsStreamAsync(), JsonSerializerOptionsUtils.DefaultJsonSerializerOptions
                    );
        }

        throw new InstaplusApiException($"API Call Failed: {(int)response.StatusCode}:{response.ReasonPhrase} \n\r  {await response.Content.ReadAsStringAsync()}");
    }
}