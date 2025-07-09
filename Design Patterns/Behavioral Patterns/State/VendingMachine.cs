namespace BehavioralPattern.State
{
  public class VendingMachine
  {
    private IState _state;

    public readonly IState NoCoinState;
    public readonly IState HasCoinState;
    public readonly IState SoldState;

    public VendingMachine()
    {
      NoCoinState = new NoCoinState(this);
      HasCoinState = new HasCoinState(this);
      SoldState = new SoldState(this);

      _state = NoCoinState; // Estado inicial
    }

    public void SetState(IState state)
    {
      _state = state;
    }

    public void InsertCoin() => _state.InsertCoin();
    public void SelectProduct() => _state.SelectProduct();
    public void DispenseProduct() => _state.DispenseProduct();
  }
}