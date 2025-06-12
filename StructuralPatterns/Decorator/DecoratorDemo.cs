namespace StructuralPatterns.Decorator
{

    // Classe para demonstrar o uso
    public class DecoratorDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== DECORATOR PATTERN ===");
            
            INotification notification = new BaseNotification();
            notification = new EmailDecorator(notification);
            notification = new SMSDecorator(notification);
            notification = new PushDecorator(notification);
            
            notification.Send("Hello World!");
        }
    }
}