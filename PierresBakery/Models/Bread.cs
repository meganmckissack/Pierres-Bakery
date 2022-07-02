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

  }
}