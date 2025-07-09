using System;

namespace BehavioralPattern.Visitor
{
  public class Program
  {
    public static void Main()
    {
      var visitor = new ValidationVisitor();
      var elementA = new ElementA();
      var elementB = new ElementB();

      elementA.Accept(visitor);
      elementB.Accept(visitor);
    }
  }
}
