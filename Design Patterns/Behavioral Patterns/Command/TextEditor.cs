namespace BehavioralPattern.Command
{
  public class TextEditor
  {
    public string Text { get; private set; } = "";

    public void Write(string newText)
    {
      Text += newText;
    }

    public void Delete(int length)
    {
      if (length <= Text.Length)
      {
        Text = Text.Substring(0, Text.Length - length);
      }
    }

    public void Print()
    {
      Console.WriteLine(Text);
    }
  }
}