using System.Text.RegularExpressions;

public record City
{
    private string value;

    public City(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new InvalidDataException("The name of city must be non-empty.");
        }

        if (Name.Length < 2)
        {
            throw new InvalidDataException("The name of city must be at least 2 characters long.");
        }

        if (!Valid(Name))
        {
            throw new InvalidDataException("The name of city must include only alphabetic or space characters.");
        }

        value = Name;
    }

    public static bool Valid(string Name)
    {
        return !new Regex(@"[^A-Za-z\sóżźćńęąłÓŻŹĆŁĄĘ]").IsMatch(Name);
    }

    public override string ToString()
    {
        return value;
    }
}