using System.Text.Json;
using System.Text.Json.Serialization;

namespace Instaplus.Net.Utils;

public class CustomJsonConverterForType : JsonConverter<Type>
{
    public override Type? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string assemblyQualifiedName = reader.GetString() ?? "";
        return Type.GetType(assemblyQualifiedName);
    }


    public override void Write(Utf8JsonWriter writer, Type value, JsonSerializerOptions options)
    {
        string assemblyQualifiedName = value!.AssemblyQualifiedName!;
        writer.WriteStringValue(assemblyQualifiedName);
    }
}