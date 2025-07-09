namespace BehavioralPattern.Strategy
{
  public interface IShippingStrategy
  {
    decimal Calculate(decimal distance);
  }
}