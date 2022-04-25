using System.Text.Json;
using System.Text.Json.Serialization;

internal class CityConverter : JsonConverter<City?>
{
    public override City? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        if (value is null)
        {
            return default;
        }
        return City.Valid(value) ? new City(value) : default;
    }

    public override void Write(Utf8JsonWriter writer, City? value, JsonSerializerOptions options)
        => writer.WriteStringValue(value?.ToString());
}