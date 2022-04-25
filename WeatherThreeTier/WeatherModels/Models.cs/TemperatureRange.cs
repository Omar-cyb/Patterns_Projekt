public class TemperatureRange : NumberRange
{
    public static NumberRange MaxRange { get; } = new NumberRange(-70, 70);
    
    public TemperatureRange(int min, int max) : base(min, max)
    {
        if (min < MaxRange.Min || max > MaxRange.Max)
        {
            throw new InvalidDataException($"Expected Range to be inside [{MaxRange.Min}, {MaxRange.Max}].");
        }
    }
}