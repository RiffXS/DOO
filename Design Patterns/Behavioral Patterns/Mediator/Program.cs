namespace BehavioralPattern.Mediator
{
  public class Program
  {
    public static void Main()
    {
      var mediator = new ChatMediator();

      var user1 = new User("Alice", mediator);
      var user2 = new User("Bob", mediator);

      user1.SendMessage("Hello, Bob!");
      user2.SendMessage("Hi, Alice!");
    }
  }
}
