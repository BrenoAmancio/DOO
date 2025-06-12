namespace BehavioralPatterns.Memento
{
    // Memento - armazena estado
    public class PlayerMemento
    {
        public int Position { get; private set; }
        public int Health { get; private set; }

        public PlayerMemento(int position, int health)
        {
            Position = position;
            Health = health;
        }
    }
}