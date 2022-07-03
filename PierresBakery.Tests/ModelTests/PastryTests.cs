using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryClass_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastryOrder = new Pastry("test pastry");
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }

    [TestMethod]
    public void GetPastryType_ReturnPastryType_String()
    {
      string pastryType = "Croissant";
      Pastry newPastryOrder = new Pastry(pastryType);
      string result = newPastryOrder.PastryType;
      Assert.AreEqual(pastryType, result);
    }
  }
}