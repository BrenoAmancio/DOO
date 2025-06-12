namespace StructuralPatterns.Adapter
{
    // Classe para demonstrar o uso
    public class AdapterDemo
    {
        public static void Execute()
        {
            Console.WriteLine("=== ADAPTER PATTERN ===");
            
            var sensors = new List<ITemperatureSensor>
            {
                new SensorAAdapter(new SensorA()),
                new SensorBAdapter(new SensorB()),
                new SensorCAdapter(new SensorC())
            };

            foreach (var sensor in sensors)
            {
                Console.WriteLine($"Temperature: {sensor.ReadTemperature()}°C");
            }
        }
    }
}