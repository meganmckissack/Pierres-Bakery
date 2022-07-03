using System;

namespace Bakery
{
  public class Pastry
  {
    public string PastryType { get; }

    public Pastry(string pastryType)
    {
      PastryType = pastryType;
    }
  }
}