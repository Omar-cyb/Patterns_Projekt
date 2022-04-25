using System.Text.Json.Serialization;

public record ForecastDTO
{
    [JsonConverter(typeof(CityConverter))]
    public City City { get; init; }

    [JsonConverter(typeof(DateOnlyConverter))]
    public DateOnly Date { get; init; }

    [JsonConverter(typeof(TemperatureConverter))]
    public Temperature Temperature { get; init; }

    public string Summary { get; init; }
}
