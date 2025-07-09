namespace BehavioralPattern.Visitor
{
  public class ElementB : IElement
  {
    public void Accept(IVisitor visitor)
    {
      visitor.Visit(this);
    }
  }
}