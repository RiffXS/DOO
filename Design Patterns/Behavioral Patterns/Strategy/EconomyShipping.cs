namespace BehavioralPattern.Strategy
{
  public class EconomyShipping : IShippingStrategy
  {
    public decimal Calculate(decimal distance)
    {
      return distance * 0.10m;
    }
  }
}