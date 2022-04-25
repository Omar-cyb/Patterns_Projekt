public class NumberRange
{
    public int Min { get; }
    public int Max { get; }
    public int Abs { get => Max - Min; }

    public int Pick() => Random.Shared.Next(Min, Max + 1);

    public NumberRange(int min, int max)
    {
        if (min > max)
        {
            throw new InvalidDataException("Expected min <= max");
        }

        Min = min;
        Max = max;
    }

    public int Map(int value, NumberRange another)
    {
        if (value > Max || value < Min)
        {
            throw new InvalidDataException($"Expected value to be inside [{Min}, {Max}].");
        }

        return (int) ((value - Min) / (double)Abs * another.Abs);
    }
}
