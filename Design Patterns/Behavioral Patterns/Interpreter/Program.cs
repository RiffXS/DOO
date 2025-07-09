using System;

namespace BehavioralPattern.Interpreter
{
  public class Program
  {
    public static void Main(string[] args)
    {
      IExpression expression = new AddExpression(
        new NumberExpression(5),
        new SubtractExpression(
          new NumberExpression(10),
          new NumberExpression(3)
        )
      );

      Console.WriteLine(expression.Interpret());
    }
  }
}
