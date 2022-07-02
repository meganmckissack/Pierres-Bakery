using System;

namespace Bakery
{
  public class Bread
  {
    public string BreadType { get; set; }
    public int BreadCost { get; }
  

    public Bread(string breadType, int breadCost)
    {
      BreadType = breadType;
      BreadCost = breadCost;
    }

  }
}