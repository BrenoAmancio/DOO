
namespace BehavioralPatterns.Observer
{

    // Interface do subject
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}