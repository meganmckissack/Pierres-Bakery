using System;

namespace Bakery
{
  public class Bread
  {
    public string BreadType { get; set; }
    public int BreadQuantity { get; set; }
  

    public Bread(string breadType, int breadQuantity)
    {
      BreadType = breadType;
      BreadQuantity = breadQuantity;
    }

    public int CalculateBreadCost(int breadQuantity)
    {
      int breadCost = 0;

      if(breadQuantity >= 3)
      {
        breadCost = (breadQuantity * 5) - (int)Math.Floor((decimal)(breadQuantity/3) * 5);
      } 
      else 
      {
        breadCost = breadQuantity * 5;
      }

      return breadCost;
    }
  }
}