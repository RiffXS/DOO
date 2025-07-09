namespace BehavioralPattern.Mediator
{
  public class User
  {
    public string Name { get; }
    private IMediator _mediator;

    public User(string name, IMediator mediator)
    {
      Name = name;
      _mediator = mediator;
      _mediator.RegisterUser(this);
    }

    public void SendMessage(string message)
    {
      _mediator.SendMessage(message, this);
    }

    public void ReceiveMessage(string message, User sender)
    {
      Console.WriteLine($"{sender.Name} to {Name}: {message}");
    }
  }
}