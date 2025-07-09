namespace BehavioralPattern.ChainOfResponsability
{
  public class ReceiptHandler : DocumentHandler
  {
    protected override bool Process(string documentType)
    {
      if (documentType == "Receipt")
      {
        Console.WriteLine("Processing Receipt...");
        return true;
      }
      return false;
    }
  }
}