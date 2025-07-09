namespace BehavioralPattern.Observer
{
  public class Program
  {
    public static void Main()
    {
      var order = new Order();

      order.Attach(new EmailNotifier());
      order.Attach(new SmsNotifier());

      order.UpdateStatus("Shipped");
    }
  }
}
