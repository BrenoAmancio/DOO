namespace BehavioralPatterns.Mediator
{

    // Mediador concreto
    public class ChatMediator : IMediator
    {
        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                if (user != sender)
                {
                    user.Receive(message, sender.Name);
                }
            }
        }
    }
}