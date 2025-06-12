namespace StructuralPatterns.Facade
{

    // Classe para demonstrar o uso
    public class FacadeDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== FACADE PATTERN ===");
            
            var homeTheater = new HomeTheaterFacade();
            homeTheater.PlayMovie("The Matrix");
            Console.WriteLine();
            homeTheater.EndMovie();
        }
    }
}