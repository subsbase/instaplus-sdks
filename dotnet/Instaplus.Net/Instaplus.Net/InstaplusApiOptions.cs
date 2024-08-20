namespace Instaplus.Net;

public class InstaplusApiOptions
{
    public string BaseUrl { get; set; } = "https://api.insta-plus.app";
    public IHttpClientFactory HttpClientFactory { get; set; } = default!;
}