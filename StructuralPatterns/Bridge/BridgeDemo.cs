namespace StructuralPatterns.Bridge
{
    public class BridgeDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== BRIDGE PATTERN ===");
            
            var shapes = new List<Shape>
            {
                new Circle(new RedColor()),
                new Circle(new BlueColor()),
                new Square(new RedColor()),
                new Square(new BlueColor())
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}