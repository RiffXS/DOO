namespace BehavioralPattern.State
{
  public class NoCoinState : IState
  {
    private readonly VendingMachine _machine;

    public NoCoinState(VendingMachine machine)
    {
      _machine = machine;
    }

    public void InsertCoin()
    {
      Console.WriteLine("Coin inserted.");
      _machine.SetState(_machine.HasCoinState);
    }

    public void SelectProduct()
    {
      Console.WriteLine("Insert coin first.");
    }

    public void DispenseProduct()
    {
      Console.WriteLine("Insert coin and select product first.");
    }
  }
}