using System;

namespace Bakery
{
  public class Bread
  {
    public string BreadType { get; }
    public int Cost { get; }
  

    public Bread(string breadType)
    {
      BreadType = breadType;
    }

  }
}