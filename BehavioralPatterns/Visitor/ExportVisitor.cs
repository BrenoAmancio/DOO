namespace BehavioralPatterns.Visitor
{

    public class ExportVisitor : IVisitor
    {
        public void Visit(ElementA element)
        {
            Console.WriteLine($"Exporting ElementA: {element.GetDataA()}");
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine($"Exporting ElementB: {element.GetDataB()}");
        }
    }
}