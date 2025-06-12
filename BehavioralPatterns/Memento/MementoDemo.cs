namespace BehavioralPatterns.Memento
{

    // Classe para demonstrar o uso
    public class MementoDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== MEMENTO PATTERN ===");
            
            var player = new Player();
            player.Position = 5;
            player.Health = 100;

            var caretaker = new Caretaker();
            caretaker.Save(player.SaveState());
            Console.WriteLine($"Saved state - Position: {player.Position}, Health: {player.Health}");

            player.Position = 10;
            player.Health = 50;
            Console.WriteLine($"Changed state - Position: {player.Position}, Health: {player.Health}");

            caretaker.Restore(player);
            Console.WriteLine($"Restored state - Position: {player.Position}, Health: {player.Health}");
        }
    }
}