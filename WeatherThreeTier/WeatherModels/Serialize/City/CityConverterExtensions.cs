using System.Text.Json;

internal static class CityConverterExtensions
{
    public static void AddCityConverters(this JsonSerializerOptions options)
    {
        options.Converters.Add(new CityConverter());
    }
}