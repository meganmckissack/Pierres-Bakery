using System;

namespace Bakery
{
  public class Pastry
  {
    public string PastryType { get; set; }

    public Pastry(string pastryType)
    {
      PastryType = pastryType;
    }
  }
}