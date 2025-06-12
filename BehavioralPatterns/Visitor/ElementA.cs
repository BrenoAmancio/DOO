namespace BehavioralPatterns.Visitor
{

    // Elementos concretos
    public class ElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string GetDataA()
        {
            return "Data from ElementA";
        }
    }
}