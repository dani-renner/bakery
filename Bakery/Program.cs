using System;
using Menu.Models;

namespace Menu
{
  public class Program
  {
    public static void Main()
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread is $5/loaf and if you buy 2, you get 1 for free!");
      Console.WriteLine("Pastries are $2 each or 3 for $5.");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("How many loaves of bread would you like?");
      try
      {
      Bread userBread = new Bread(int.Parse(Console.ReadLine()));
      }
      catch
      {
        Console.WriteLine("Please only enter integers");
        Main();
      }
      Console.WriteLine("Okay! And how many pastries would you like?");
      Pastry userPastry = new Pastry(int.Parse(Console.ReadLine()));
      int userCost = userBread.BreadCost()+userPastry.PastryCost();
      Console.WriteLine("Fabulous! Your total is ${0}.",userCost);
    }
  }
}