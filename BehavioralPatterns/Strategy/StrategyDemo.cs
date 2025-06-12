namespace BehavioralPatterns.Strategy
{

    // Classe para demonstrar o uso
    public class StrategyDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== STRATEGY PATTERN ===");
            
            var calculator = new ShippingCalculator(new EconomyShipping());
            Console.WriteLine($"Economy shipping: ${calculator.Calculate(100)}");

            calculator.SetStrategy(new ExpressShipping());
            Console.WriteLine($"Express shipping: ${calculator.Calculate(100)}");

            calculator.SetStrategy(new LocalShipping());
            Console.WriteLine($"Local shipping: ${calculator.Calculate(100)}");
        }
    }
}