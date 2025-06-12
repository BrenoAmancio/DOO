namespace BehavioralPatterns.Observer
{

    // Classe para demonstrar o uso
    public class ObserverDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== OBSERVER PATTERN ===");
            
            var order = new Order();
            order.Attach(new EmailNotifier());
            order.Attach(new SmsNotifier());
            order.Attach(new AppNotifier());

            order.UpdateStatus("Shipped");
        }
    }
}