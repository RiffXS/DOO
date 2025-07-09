namespace BehavioralPattern.Iterator
{
  public class Program
  {
    public static void Main()
    {
      var playlist = new Playlist();
      playlist.Add("Song 1");
      playlist.Add("Song 2");
      playlist.Add("Song 3");

      Console.WriteLine("Modo ordenado:");
      playlist.SetShuffle(false);
      foreach (var song in playlist)
      {
        Console.WriteLine(song);
      }

      Console.WriteLine("\nModo aleatório:");
      playlist.SetShuffle(true);
      foreach (var song in playlist)
      {
        Console.WriteLine(song);
      }
    }
  }
}
