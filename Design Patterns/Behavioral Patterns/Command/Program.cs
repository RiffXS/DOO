namespace BehavioralPattern.Command
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var editor = new TextEditor();
      var commandManager = new CommandManager();

      commandManager.ExecuteCommand(new WriteTextCommand(editor, "Hello, "));
      commandManager.ExecuteCommand(new WriteTextCommand(editor, "world!"));

      commandManager.Undo();
      commandManager.Undo();
      commandManager.Redo();

      editor.Print();
    }
  }
}
