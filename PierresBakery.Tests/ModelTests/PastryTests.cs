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
      int pastryQuantity = 5;
      Pastry newPastryOrder = new Pastry("test pastry", pastryQuantity);
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }

    [TestMethod]
    public void GetPastryType_ReturnPastryType_String()
    {
      string pastryType = "Croissant";
      int pastryQuantity = 5;
      Pastry newPastryOrder = new Pastry(pastryType, pastryQuantity);
      string result = newPastryOrder.PastryType;
      Assert.AreEqual(pastryType, result);
    }

    [TestMethod]
    public void SetPastryType_SetPastryTypeInput_String()
    {
      string pastryType = "Croissant";
      int pastryQuantity = 5;
      Pastry newPastryOrder = new Pastry(pastryType, pastryQuantity);
      string updatePastryType = "Scone";
      newPastryOrder.PastryType = updatePastryType;
      string result = newPastryOrder.PastryType;
      Assert.AreEqual(updatePastryType, result);
    }

    [TestMethod]
    public void GetPastryQuantity_ReturnPastryQuantity_Int()
    {
      string pastryType = "Croissant";
      int pastryQuantity = 5;
      Pastry newPastryOrder = new Pastry(pastryType, pastryQuantity);
      int result = newPastryOrder.PastryQuantity;
      Assert.AreEqual(pastryQuantity, result);
    }
  }
}