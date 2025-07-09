namespace BehavioralPattern.ChainOfResponsability
{
  public class BillHandler : DocumentHandler
  {
    protected override bool Process(string documentType)
    {
      if (documentType == "Bill")
      {
        Console.WriteLine("Processing Bill...");
        return true;
      }
      return false;
    }
  }
}