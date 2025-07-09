using System;

namespace BehavioralPattern.Strategy
{
  public class Program
  {
    public static void Main()
    {
      var calculator = new ShippingCalculator(new EconomyShipping());
      Console.WriteLine(calculator.Calculate(100)); // Saída: 10

      calculator.SetStrategy(new ExpressShipping());
      Console.WriteLine(calculator.Calculate(100)); // Saída: 25
    }
  }
}
