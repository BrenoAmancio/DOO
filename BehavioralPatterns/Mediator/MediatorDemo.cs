namespace BehavioralPatterns.Mediator
{

    // Classe para demonstrar o uso
    public class MediatorDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== MEDIATOR PATTERN ===");
            
            var mediator = new ChatMediator();

            var user1 = new User("Alice", mediator);
            var user2 = new User("Bob", mediator);
            var user3 = new User("Charlie", mediator);

            user1.SendMessage("Hello, Bob!");
            user2.SendMessage("Hi, Alice!");
            user3.SendMessage("Hello everyone!");
        }
    }
}