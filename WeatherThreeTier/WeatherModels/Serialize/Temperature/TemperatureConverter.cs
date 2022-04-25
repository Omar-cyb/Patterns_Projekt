using System.Text.Json;
using System.Text.Json.Serialization;

internal class TemperatureConverter : JsonConverter<Temperature?>
{
    public override Temperature? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        if (value is null)
        {
            return default;
        }

        if (Temperature.TryParse(value, out var result))
        {
            return result;
        }

        return default;
    }

    public override void Write(Utf8JsonWriter writer, Temperature? value, JsonSerializerOptions options)
        => writer.WriteStringValue(value?.ToString());
}