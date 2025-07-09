namespace BehavioralPattern.Memento
{
  public class PlayerMemento : IMemento
  {
    private Player _state;

    public PlayerMemento(int position, int health)
    {
      _state = new Player();
      _state.Position = position;
      _state.Health = health;
    }

    public Player GetState()
    {
      return _state;
    }
  }
}