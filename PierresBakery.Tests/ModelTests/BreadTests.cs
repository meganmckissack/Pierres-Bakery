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
      Bread newBreadOrder = new Bread();
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }
  }
}