namespace BehavioralPattern.Visitor
{
  public interface IVisitor
  {
    void Visit(ElementA elementA);
    void Visit(ElementB elementB);
  }
}