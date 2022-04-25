using System.Text.RegularExpressions;

public record Temperature
{
    private int value;
    private TemperatureRange valueRange;

    private static string[] summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public Temperature(int value, TemperatureRange Celsius)
    {
        valueRange = Celsius;

        if (value < valueRange.Min || value > valueRange.Max)
        {
            throw new InvalidDataException($"Expected value to be in range [{valueRange.Min}, {valueRange.Max}].");
        }

        this.value = value;
    }

    public Temperature(int value, NumberRange Celsius) : this(value, new TemperatureRange(Celsius.Min, Celsius.Max)) { }

    public Temperature(TemperatureRange Celsius) : this(Celsius.Pick(), Celsius) { }

    public Temperature(NumberRange Celsius) : this(new TemperatureRange(Celsius.Min, Celsius.Max)) { }

    public Temperature(int value) : this(value, new TemperatureRange(-22, 35)) { }

    public Temperature()
    {
        valueRange = new TemperatureRange(-22, 35);
        value = valueRange.Pick();
    }

    private int TemperatureC => value;
    private int TemperatureF => 32 + (int)(value / 0.5556);

    private static int GetCelsius(int Fahrenheit)
    {
        return (int) ((Fahrenheit - 32) / 1.8);
    }

    public static Temperature Parse(string value)
    {
        var v = value.Trim().Replace(" ", "").ToUpper();

        var digitsPattern = new Regex(@"^-{0,}\d*(?=[\w°CF]|$)(?!\d)");
        var celsiusPattern = new Regex(@"(?<=[\w°\d])(?!^)C$");
        var fahrenheihtPattern = new Regex(@"(?<=[\w°\d])(?!^)F$");

        if (!digitsPattern.IsMatch(v))
        {
            throw new InvalidDataException("Expected value to have digits.");
        }

        if (celsiusPattern.IsMatch(v))
        {
            return new Temperature(int.Parse(digitsPattern.Match(v).Groups[0].Value), TemperatureRange.MaxRange);
        }
        else if (fahrenheihtPattern.IsMatch(v))
        {
            return new Temperature(GetCelsius(int.Parse(digitsPattern.Match(v).Groups[0].Value)), TemperatureRange.MaxRange);
        }
        else
        {
            var valStr = digitsPattern.Replace(value, "");
            if (valStr.Length > 0)
            {
                throw new InvalidDataException($"Expected format 0°C or 0°F or 0. Got: 0{valStr}");
            }

            return new Temperature(int.Parse(digitsPattern.Match(v).Groups[0].Value), TemperatureRange.MaxRange);
        }
    }

    public static bool TryParse(string value, out Temperature? temperature)
    {
        try
        {
            temperature = Parse(value);
            return true;
        }
        catch
        {
            temperature = null;
            return false;
        }
    }

    public string ToString(string format)
    {
        switch (format.ToUpper())
        {
            case "C":
                return $"{TemperatureC}°C";
            case "F":
                return $"{TemperatureF}°F";
            default:
                throw new FormatException($"Invalid format provided: {format}. Expected C or F");
        }
    }

    public string Summary
    {
        get
        {
            return summaries[valueRange.Map(value, new NumberRange(0, summaries.Length - 1))];
        }
    }

    public override string ToString()
    {
        return ToString("C");
    }
}