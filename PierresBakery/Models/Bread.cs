using System;

namespace Bakery
{
  public class Bread
  {
    public string BreadType { get; set; }
    public int BreadQuantity { get; set; }
    public int BreadCost { get; }
  

    public Bread(string breadType, int breadQuantity, int breadCost)
    {
      BreadType = breadType;
      BreadQuantity = breadQuantity;
      BreadCost = breadCost;
    }

  }
}