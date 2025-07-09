namespace BehavioralPattern.Mediator
{
  public interface IMediator
  {
    void SendMessage(string message, User sender);
    void RegisterUser(User user);
  }
}