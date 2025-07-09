namespace BehavioralPattern.Strategy
{
  public class LocalShipping : IShippingStrategy
  {
    public decimal Calculate(decimal distance)
    {
      return 5.00m;
    }
  }
}