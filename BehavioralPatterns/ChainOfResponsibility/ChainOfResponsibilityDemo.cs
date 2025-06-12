namespace BehavioralPatterns.ChainOfResponsibility
{

    public class ChainOfResponsibilityDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== CHAIN OF RESPONSIBILITY PATTERN ===");
            
            var handler = new InvoiceHandler();
            handler.SetNext(new ReceiptHandler()).SetNext(new BillHandler());

            handler.Handle("Invoice");
            handler.Handle("Unknown");
        }
    }
}