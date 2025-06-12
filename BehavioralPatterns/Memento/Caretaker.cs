namespace BehavioralPatterns.Memento
{
    public class Caretaker
    {
        private Stack<PlayerMemento> _mementos = new Stack<PlayerMemento>();

        public void Save(PlayerMemento memento)
        {
            _mementos.Push(memento);
        }

        public void Restore(Player player)
        {
            if (_mementos.Count > 0)
            {
                var memento = _mementos.Pop();
                player.RestoreState(memento);
            }
        }
    }
}