namespace BehavioralPatterns.Visitor
{

    // Visitantes concretos
    public class ValidationVisitor : IVisitor
    {
        public void Visit(ElementA element)
        {
            Console.WriteLine($"Validating ElementA: {element.GetDataA()}");
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine($"Validating ElementB: {element.GetDataB()}");
        }
    }
}