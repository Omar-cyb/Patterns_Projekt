public class Repository
{
    public IList<City> Cities { get; }
    public IList<Forecast> Forecasts { get; }
    private bool seeded;

    public Repository()
    {
        Cities = new List<City>();
        Forecasts = new List<Forecast>();
        seeded = false;
    }

    public void Seed()
    {
        if (!seeded)
        {
            SeedCities();
            SeedForecasts(7);
            seeded = true;
        }
        else
        {
            throw new AlreadySeededException();
        }
    }

    private void SeedCities()
    {
        var cities = new[]
        {
            "Warszawa",
            "Kraków",
            "Łódź",
            "Wrocław",
            "Poznań",
            "Gdańsk",
            "Szczecin",
            "Bydgoszcz",
            "Lublin",
            "Białystok"
        };

        foreach (var city in cities)
        {
            Cities.Add(new City(city));
        }
    }

    private void SeedForecasts(int maxDays)
    {
        if (maxDays < 1)
        {
            throw new InvalidSeedDataException("Expected maxDays to be at least 1.");
        }

        if (!Cities.Any())
        {
            throw new InvalidSeedOrderException("Cities must be seeded first.");
        }

        foreach (var city in Cities)
        {
            for (int days = 1; days <= maxDays; days++)
            {
                Forecasts.Add(new Forecast(city, days));
            }
        }
    }
}