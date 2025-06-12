namespace BehavioralPatterns.Command
{
    // Interface de comando
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}