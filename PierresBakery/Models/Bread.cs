using System;

namespace Bakery
{
  public class Bread
  {
    public string BreadType { get; set; }
    public int BreadQuantity { get; }
    public int BreadCost { get; }
  

    public Bread(string breadType, int breadCost, int breadQuantity)
    {
      BreadType = breadType;
      BreadCost = breadCost;
      BreadQuantity = breadQuantity;
    }

  }
}