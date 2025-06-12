namespace BehavioralPatterns.Visitor
{

    public class ElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string GetDataB()
        {
            return "Data from ElementB";
        }
    }
}