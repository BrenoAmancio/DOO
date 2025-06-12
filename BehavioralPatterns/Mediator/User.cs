namespace BehavioralPatterns.Mediator
{

    // Classe User
    public class User
    {
        private IMediator _mediator;
        public string Name { get; private set; }

        public User(string name, IMediator mediator)
        {
            Name = name;
            _mediator = mediator;
            _mediator.AddUser(this);
        }

        public void SendMessage(string message)
        {
            _mediator.SendMessage(message, this);
        }

        public void Receive(string message, string senderName)
        {
            Console.WriteLine($"{senderName} to {Name}: {message}");
        }
    }
}