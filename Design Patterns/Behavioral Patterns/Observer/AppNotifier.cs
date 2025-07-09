namespace BehavioralPattern.Observer
{
  public class AppNotifier : IObserver
  {
    public void Update(ISubject subject)
    {
      Console.WriteLine($"App Notification: Your order is now {(subject as Order)?.Status}.");
    }
  }
}