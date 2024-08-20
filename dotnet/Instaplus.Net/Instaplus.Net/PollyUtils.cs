using System.Net;
using Microsoft.Extensions.Logging;
using Polly;
using Polly.Retry;

namespace Instaplus.Net;

internal static class PollyUtils
{
    public static AsyncRetryPolicy<HttpResponseMessage> GetRetryPolicy()
    {
        var retryStatuses = new [] { HttpStatusCode.TooManyRequests, HttpStatusCode.InternalServerError, HttpStatusCode.BadGateway, HttpStatusCode.ServiceUnavailable, HttpStatusCode.GatewayTimeout, HttpStatusCode.RequestTimeout };
        return Policy
            .HandleResult<HttpResponseMessage>(r => retryStatuses.Contains(r.StatusCode))
            .Or<HttpRequestException>()
            .WaitAndRetryAsync(3, retryAttempt =>
                    TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
                onRetry: (outcome, timespan, retryAttempt, context) =>
                {
                    Console.WriteLine(@$"Request failed with {outcome.Exception?.Message}. 
                    Waiting {timespan} before next retry. Retry attempt {retryAttempt}.");
                });
    }
}