namespace BehavioralPattern.Observer
{
  public class SmsNotifier : IObserver
  {
    public void Update(ISubject subject)
    {
      Console.WriteLine($"SMS: Your order is now {(subject as Order)?.Status}.");
    }
  }
}