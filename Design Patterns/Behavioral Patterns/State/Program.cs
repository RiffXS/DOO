using System;

namespace BehavioralPattern.State
{
  public class Program
  {
    public static void Main()
    {
      var vendingMachine = new VendingMachine();

      vendingMachine.InsertCoin();
      vendingMachine.SelectProduct();
      vendingMachine.DispenseProduct();
    }
}
}
