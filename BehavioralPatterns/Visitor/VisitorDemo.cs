namespace BehavioralPatterns.Visitor
{

    // Classe para demonstrar o uso
    public class VisitorDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== VISITOR PATTERN ===");
            
            var elements = new List<IElement>
            {
                new ElementA(),
                new ElementB()
            };

            var validationVisitor = new ValidationVisitor();
            var exportVisitor = new ExportVisitor();

            Console.WriteLine("Validation:");
            foreach (var element in elements)
            {
                element.Accept(validationVisitor);
            }

            Console.WriteLine("\nExport:");
            foreach (var element in elements)
            {
                element.Accept(exportVisitor);
            }
        }
    }
}