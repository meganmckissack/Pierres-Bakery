using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadClass_CreatesInstanceOfBread_Bread()
    {
      Bread newBreadOrder = new Bread("testBreadType", 3);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

    [TestMethod]
    public void GetBreadType_ReturnBreadType_String()
    {
      string breadType = "Challah";
      int breadQuantity = 3;
      Bread newBreadOrder = new Bread(breadType, breadQuantity);
      string result = newBreadOrder.BreadType;
      Assert.AreEqual(breadType, result);
    }

    [TestMethod]
    public void SetBreadType_SetBreadTypeInput_String()
    {
      string breadType = "Challah";
      int breadQuantity = 3;
      Bread newBreadOrder = new Bread(breadType, breadQuantity);
      string updateBreadType = "Focaccia";
      newBreadOrder.BreadType = updateBreadType;
      string result = newBreadOrder.BreadType;
      Assert.AreEqual(updateBreadType, result);
    }

    [TestMethod]
    public void GetBreadQuantity_ReturnBreadQuantity_Int()
    {
      string breadType = "Challah";
      int breadQuantity = 3;
      Bread newBreadOrder = new Bread(breadType, breadQuantity);
      int result = newBreadOrder.BreadQuantity;
      Assert.AreEqual(breadQuantity, result);
    }

    [TestMethod]
    public void SetBreadQuantity_SetBreadQuantity_Int()
    {
      string breadType = "Challah";
      int breadQuantity = 3;
      Bread newBreadOrder = new Bread(breadType, breadQuantity);
      int updateBreadQuantity = 7;
      newBreadOrder.BreadQuantity = updateBreadQuantity;
      int result = newBreadOrder.BreadQuantity;
      Assert.AreEqual(updateBreadQuantity, result);
    }

    [TestMethod]
    public void CalculateBreadCost_GetBreadCost_Int()
    {
      string breadType = "Challah";
      int breadQuantity = 7;
      Bread newBreadOrder = new Bread(breadType, breadQuantity);
      int result = newBreadOrder.CalculateBreadCost(breadQuantity);
      Assert.AreEqual(25, result);
    }

  }
}