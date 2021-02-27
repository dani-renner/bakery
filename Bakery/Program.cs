using System;
using System.Collections.Generic;
using Menu.Models;

namespace Menu
{
  public class Program
  {
    public static void Main()
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("White Bread is $5/loaf and if you buy 2, you get 1 for free!");
      Console.WriteLine("Wheat Bread is $5/loaf, and");
      Console.WriteLine("Pastries are $2 each or 3 for $5.");
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("How many loaves of white bread would you like?");
      bool breadParsedCorrectly = int.TryParse(Console.ReadLine(), out int breadEntry);
      if (!breadParsedCorrectly)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please enter only an integer.");
        Main();
        return;
      }
      Console.WriteLine("How many loaves of wheat bread would you like?");
      bool wheatBreadParsedCorrectly = int.TryParse(Console.ReadLine(), out int wheatBreadEntry);
      if (!wheatBreadParsedCorrectly)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please enter only an integer.");
        Main();
        return;
      }
      Bread userBread = new Bread(breadEntry,wheatBreadEntry);
      Console.WriteLine("Okay! And how many pastries would you like?");
      bool pastryParsedCorrectly = int.TryParse(Console.ReadLine(), out int pastryEntry);
      if (!pastryParsedCorrectly)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please enter only an integer.");
        Main();
        return;
      }
      Pastry userPastry = new Pastry(pastryEntry);
      int userCost = userBread.BreadCost()+userPastry.PastryCost();
      Console.WriteLine("Fabulous! Your total is ${0}.",userCost);
    }
  }
}