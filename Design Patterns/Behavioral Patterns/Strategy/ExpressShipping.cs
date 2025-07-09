namespace BehavioralPattern.Strategy
{
  public class ExpressShipping : IShippingStrategy
  {
    public decimal Calculate(decimal distance)
    {
      return distance * 0.25m;
    }
  }
}