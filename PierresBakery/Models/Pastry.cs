using System;

namespace Bakery
{
  public class Pastry
  {
    public string PastryType { get; set; }
    public int PastryQuantity { get; set; }

    public Pastry(string pastryType, int pastryQuantity)
    {
      PastryType = pastryType;
      PastryQuantity = pastryQuantity;
    }

    public int CalculatePastryCost(int pastryQuantity)
    {
      int pastryCost = 0;

      if(pastryQuantity >= 3 && pastryQuantity % 3 == 0) 
      {
        pastryCost = (pastryQuantity/3) * 5;
      }
      else if (pastryQuantity >= 3)
      {
        pastryCost = (int)Math.Floor((decimal)(pastryQuantity/3) * 5) + 2;
      }
      else
      {
        pastryCost = pastryQuantity * 2;
      }
      return pastryCost;
    }
  }
}