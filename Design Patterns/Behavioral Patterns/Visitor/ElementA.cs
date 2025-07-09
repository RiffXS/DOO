namespace BehavioralPattern.Visitor
{
  public class ElementA : IElement
  {
    public void Accept(IVisitor visitor)
    {
      visitor.Visit(this);
    }
  }
}