namespace BehavioralPattern.Strategy
{
  public class ShippingCalculator
  {
    private IShippingStrategy _strategy;

    public ShippingCalculator(IShippingStrategy strategy)
    {
      _strategy = strategy;
    }

    public void SetStrategy(IShippingStrategy strategy)
    {
      _strategy = strategy;
    }

    public decimal Calculate(decimal distance)
    {
      return _strategy.Calculate(distance);
    }
  }
}