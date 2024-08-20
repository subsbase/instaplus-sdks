using System.Text.Json;
using System.Text.Json.Serialization;

namespace Instaplus.Net.Utils;

public class CustomJsonConverterForString : JsonConverter<string>
{
    public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number)
        {
            return reader.GetInt32().ToString(); // You can change this conversion logic as needed
        }

        if (reader.TokenType is JsonTokenType.True or JsonTokenType.False)
        {
            return reader.GetBoolean().ToString();
        }

        return reader.GetString();
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}