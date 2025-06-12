namespace BehavioralPatterns.Visitor
{
    // Interface do visitante
    public interface IVisitor
    {
        void Visit(ElementA element);
        void Visit(ElementB element);
    }
}