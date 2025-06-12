namespace StructuralPatterns.Proxy
{

    // Classe para demonstrar o uso
    public class ProxyDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== PROXY PATTERN ===");
            
            IImage image = new ProxyImage("high_resolution_photo.jpg");
            
            Console.WriteLine("Image created (not loaded yet)");
            Console.WriteLine("Calling Display() first time:");
            image.Display();
            
            Console.WriteLine("\nCalling Display() second time:");
            image.Display();
        }
    }
}