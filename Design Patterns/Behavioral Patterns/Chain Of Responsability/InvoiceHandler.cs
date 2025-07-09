namespace BehavioralPattern.ChainOfResponsability
{
  public class InvoiceHandler : DocumentHandler
  {
    protected override bool Process(string documentType)
    {
      if (documentType == "Invoice")
      {
        Console.WriteLine("Processing Invoice...");
        return true;
      }
      return false;
    }
  }
}