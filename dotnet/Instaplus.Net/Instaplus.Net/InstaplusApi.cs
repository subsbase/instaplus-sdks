using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Instaplus.Net.Models;
using Instaplus.Net.Requests;
using Instaplus.Net.Utils;
using Polly;
using Polly.Registry;

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
        return await GetAsync<Order>($"/order/{orderId}");
    }

    public async Task<GroupOrder?> GetGroupOrder(string groupId)
    {
        return await GetAsync<GroupOrder>($"/group-order/{groupId}");
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
        var serialized = JsonSerializer.Serialize(payload, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = false});
        var content = new StringContent(serialized, Encoding.UTF8, "application/json");

        var retryPolicy = PollyUtils.GetRetryPolicy();
        
        var response = await retryPolicy.ExecuteAsync( async () =>
            await _httpClient.PostAsync(url, content));

        if (response.IsSuccessStatusCode)
        {
            return await JsonSerializer.DeserializeAsync<TSuccessResponse>(await response.Content.ReadAsStreamAsync(),
                new JsonSerializerOptions { AllowTrailingCommas = true, PropertyNameCaseInsensitive = true });
        }

        throw new InstaplusApiException($"API Call Failed: {(int)response.StatusCode}:{response.ReasonPhrase} \n\r  {await response.Content.ReadAsStringAsync()}");
    }
    
    private async Task<TSuccessResponse?> GetAsync<TSuccessResponse>(string url)
    {
       var retryPolicy = PollyUtils.GetRetryPolicy();
        
        var response = await retryPolicy.ExecuteAsync( async () =>
            await _httpClient.GetAsync(url));

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var deserialized = JsonSerializer.Deserialize<TSuccessResponse>(content, GetJsonSerializationOptions());
            
            return await JsonSerializer.DeserializeAsync<TSuccessResponse>(await response.Content.ReadAsStreamAsync(), GetJsonSerializationOptions());
        }

        throw new InstaplusApiException($"API Call Failed: {(int)response.StatusCode}:{response.ReasonPhrase} \n\r  {await response.Content.ReadAsStringAsync()}");
    }

    private JsonSerializerOptions? GetJsonSerializationOptions()
    {
        return new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            Converters =
            {
                new CustomJsonConverterForString(),
                new CustomJsonConverterForDecimal(),
                new CustomJsonConverterForDateTime()
            }
        };
    }

    private async Task<TSuccessResponse?> AuthorizedPutAsync<TPayload, TSuccessResponse>(string url, TPayload payload, TSuccessResponse successResponse)
        where TSuccessResponse : class
    {
        var serialized = JsonSerializer.Serialize(payload, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = false});
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
                : await JsonSerializer.DeserializeAsync<TSuccessResponse>(await response.Content.ReadAsStreamAsync(),
                new JsonSerializerOptions { AllowTrailingCommas = true, PropertyNameCaseInsensitive = true });
        }

        throw new InstaplusApiException($"API Call Failed: {(int)response.StatusCode}:{response.ReasonPhrase} \n\r  {await response.Content.ReadAsStringAsync()}");
    }
}