namespace BehavioralPattern.ChainOfResponsability
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var handler = new InvoiceHandler();
      handler.SetNext(new ReceiptHandler()).SetNext(new BillHandler());

      handler.Handle("Invoice");
      handler.Handle("Bill");
      handler.Handle("Unknown");
    }
  }
}
