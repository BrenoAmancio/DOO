namespace BehavioralPatterns.Memento
{

    // Originator - objeto cujo estado é salvo
    public class Player
    {
        public int Position { get; set; }
        public int Health { get; set; }

        public PlayerMemento SaveState()
        {
            return new PlayerMemento(Position, Health);
        }

        public void RestoreState(PlayerMemento memento)
        {
            Position = memento.Position;
            Health = memento.Health;
        }
    }
}