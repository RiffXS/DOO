namespace BehavioralPattern.Observer
{
  public class Order : ISubject
  {
    private readonly List<IObserver> _observers = new List<IObserver>();
    public string? Status;

    public void Attach(IObserver observer)
    {
      _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
      _observers.Remove(observer);
    }

    public void Notify()
    {
      foreach (var observer in _observers)
      {
        observer.Update(this);
      }
    }

    public void UpdateStatus(string status)
    {
      Status = status;
      Notify();
    }
  }
}