namespace StructuralPatterns.Flyweight
{

    // Classe para demonstrar o uso
    public class FlyweightDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== FLYWEIGHT PATTERN ===");
            
            var trees = new List<Tree>();
            var random = new Random();

            // Criar muitas árvores com poucos tipos
            for (int i = 0; i < 10; i++)
            {
                var treeType = TreeFactory.GetTreeType(
                    random.Next(2) == 0 ? "Oak" : "Pine",
                    random.Next(2) == 0 ? "Green" : "Brown",
                    "Rough"
                );
                
                trees.Add(new Tree(random.Next(100), random.Next(100), treeType));
            }

            Console.WriteLine($"\nTotal trees: {trees.Count}");
            Console.WriteLine($"TreeTypes created: {TreeFactory.GetCreatedTreeTypesCount()}");
            
            Console.WriteLine("\nRendering trees:");
            foreach (var tree in trees)
            {
                tree.Render();
            }
        }
    }
}