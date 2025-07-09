namespace BehavioralPattern.State
{
  public class HasCoinState : IState
  {
    private readonly VendingMachine _machine;

    public HasCoinState(VendingMachine machine)
    {
      _machine = machine;
    }

    public void InsertCoin()
    {
      Console.WriteLine("Coin already inserted.");
    }

    public void SelectProduct()
    {
      Console.WriteLine("Product selected.");
      _machine.SetState(_machine.SoldState);
    }

    public void DispenseProduct()
    {
      Console.WriteLine("Select product first.");
    }
  }
}