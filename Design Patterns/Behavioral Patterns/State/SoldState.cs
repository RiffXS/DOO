namespace BehavioralPattern.State
{
  public class SoldState : IState
  {
    private readonly VendingMachine _machine;

    public SoldState(VendingMachine machine)
    {
      _machine = machine;
    }

    public void InsertCoin()
    {
      Console.WriteLine("Wait, dispensing in progress.");
    }

    public void SelectProduct()
    {
      Console.WriteLine("Already selected.");
    }

    public void DispenseProduct()
    {
      Console.WriteLine("Product dispensed.");
      _machine.SetState(_machine.NoCoinState);
    }
  }
}