namespace BehavioralPatterns.Visitor
{

    // Interface dos elementos
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}