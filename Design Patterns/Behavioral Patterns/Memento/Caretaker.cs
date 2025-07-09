namespace BehavioralPattern.Memento
{
  public class Caretaker
  {
    private List<IMemento> _mementos = new List<IMemento>();

    public void Save(IMemento memento)
    {
      _mementos.Add(memento);
    }

    public void Restore(Player player)
    {
      if (_mementos.Count == 0)
      {
        return;
      }

      var memento = _mementos.Last();
      _mementos.Remove(memento);

      player.RestoreState(memento);
    }
  }
}