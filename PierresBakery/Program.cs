using System;
using Bakery;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("__________________________");
      Console.WriteLine("Today's Deals");
      Console.WriteLine("Bread -- $5 a loaf or Buy 2 get one free!");
      Console.WriteLine("Pastries -- 1 for $2, 3 for $5, 4 for $7, 5 for $9, or 6 for $10");
      Console.WriteLine("__________________________");
      Console.WriteLine("How many loaves of bread would you like to order?");
      
      //for future iterations
      string breadStyle = "Challah";
      string pastryStyle = "Croissant";

      string loavesEntered = Console.ReadLine();
      int breadQtyInput = int.Parse(loavesEntered);

      Bread newBreadOrder = new Bread(breadStyle, breadQtyInput);

      Console.WriteLine("How may pastries would you like to order?");

      string pastriesEntered = Console.ReadLine();
      int pastryQtyInput = int.Parse(pastriesEntered);

      Pastry newPastryOrder = new Pastry(pastryStyle, pastryQtyInput);

      int breadTotal = newBreadOrder.CalculateBreadCost(breadQtyInput);
      int pastryTotal = newPastryOrder.CalculatePastryCost(pastryQtyInput);
      int totalCost = breadTotal + pastryTotal;
      
      Console.WriteLine("Your " + breadQtyInput + "loaves of bread order comes to "  +  breadTotal);
      Console.WriteLine("Your " + pastryQtyInput + "pastries order comes to "  +  pastryTotal);

      Console.WriteLine("__________________________");

      Console.WriteLine("Your total cost is $" + totalCost + ".");
      





    }
  }
}
