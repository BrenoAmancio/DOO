namespace BehavioralPatterns.State
{

    // Classe para demonstrar o uso
    public class StateDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== STATE PATTERN ===");
            
            var vendingMachine = new VendingMachine();

            vendingMachine.InsertCoin();
            vendingMachine.SelectProduct();
            vendingMachine.DispenseProduct();
        }
    }
}
