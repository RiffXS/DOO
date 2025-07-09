namespace BehavioralPattern.Memento
{
  public class Player
  {
    public int Position { get; set; }
    public int Health { get; set; }

    public IMemento SaveState()
    {
      return new PlayerMemento(Position, Health);
    }

    // Restaura o estado salvo
    public void RestoreState(IMemento memento)
    {
      Position = memento.GetState().Position;
      Health = memento.GetState().Health;
    }
  }
}