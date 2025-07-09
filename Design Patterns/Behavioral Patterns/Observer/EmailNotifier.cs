namespace BehavioralPattern.Observer
{
  public class EmailNotifier : IObserver
  {
    public void Update(ISubject subject)
    {
      Console.WriteLine($"Email: Your order is now {(subject as Order)?.Status}.");
    }
  }
}