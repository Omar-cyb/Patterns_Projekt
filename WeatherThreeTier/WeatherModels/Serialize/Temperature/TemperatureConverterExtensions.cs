using System.Text.Json;

internal static class TemperatureConverterExtensions
{
    public static void AddTemperatureConverters(this JsonSerializerOptions options)
    {
        options.Converters.Add(new TemperatureConverter());
    }
}