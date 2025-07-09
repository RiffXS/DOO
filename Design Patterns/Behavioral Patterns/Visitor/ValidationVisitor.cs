namespace BehavioralPattern.Visitor
{
  public class ValidationVisitor : IVisitor
  {
    public void Visit(ElementA elementA)
    {
      Console.WriteLine("Validating ElementA...");
    }

    public void Visit(ElementB elementB)
    {
      Console.WriteLine("Validating ElementB...");
    }
  }
}