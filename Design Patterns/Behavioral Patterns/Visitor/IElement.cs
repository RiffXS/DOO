namespace BehavioralPattern.Visitor
{
  public interface IElement
  {
    void Accept(IVisitor visitor);
  }
}