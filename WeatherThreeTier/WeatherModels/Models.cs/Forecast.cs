public record Forecast
{
    public City City { get; }
    public DateOnly Date { get; }
    public Temperature Temperature { get; }
    public string Summary { get; }

    public Forecast(City city, int days)
    {
        if (days > 0)
        {
            City = city;
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(days));
            Temperature = new Temperature();
            Summary = Temperature.Summary;
        }
        else
        {
            throw new InvalidDataException("Expected days to be greater than 0.");
        }
    }
}