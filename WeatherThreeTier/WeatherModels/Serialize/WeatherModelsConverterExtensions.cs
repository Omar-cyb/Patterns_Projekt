using System.Text.Json;

public static class WeatherModelsConverterExtensions
{
    public static void AddWheatherModelsConverters(this JsonSerializerOptions options)
    {
        options.AddDateOnlyConverters();
        options.AddCityConverters();
        options.AddTemperatureConverters();
        options.PropertyNameCaseInsensitive = true;
    }
}