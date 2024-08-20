namespace Instaplus.Net;

public class InstaplusApiException : Exception
{
    public InstaplusApiException(string message): base(message) {}
}