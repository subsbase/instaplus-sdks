using System.Text.Json;

namespace Instaplus.Net.Utils;

public static class JsonSerializerOptionsUtils
{
    public static JsonSerializerOptions DefaultJsonSerializerOptions => new()
    {
        AllowTrailingCommas = true,
        PropertyNameCaseInsensitive = true,
        WriteIndented = false
    };
}