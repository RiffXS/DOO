using System;

namespace BehavioralPattern.Memento
{
  public class Program
  {
    public static void Main()
    {
      var player = new Player();
      player.Position = 5;
      player.Health = 100;

      var caretaker = new Caretaker();
      caretaker.Save(player.SaveState());

      player.Position = 10;

      caretaker.Restore(player);
      Console.WriteLine(player.Position);
    }
  }
}
