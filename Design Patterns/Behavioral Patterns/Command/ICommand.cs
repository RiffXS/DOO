namespace BehavioralPattern.Command
{
  public interface ICommand
  {
    void Execute();
    void Undo();
  }
}