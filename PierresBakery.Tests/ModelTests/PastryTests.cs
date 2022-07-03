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
      Pastry newPastryOrder = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }
  }
}