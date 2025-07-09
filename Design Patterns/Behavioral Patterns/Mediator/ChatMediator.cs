namespace BehavioralPattern.Mediator
{
  public class ChatMediator : IMediator
  {
    private List<User> _users = new List<User>();

    public void RegisterUser(User user)
    {
      if (!_users.Contains(user))
      {
        _users.Add(user);
      }
    }

    public void SendMessage(string message, User sender)
    {
      foreach (var user in _users)
      {
        if (user != sender)
        {
          user.ReceiveMessage(message, sender);
        }
      }
    }
  }
}