namespace StructuralPatterns.Adapter
{
    // Interface comum para sensores de temperatura
    public interface ITemperatureSensor
    {
        double ReadTemperature();
    }
}