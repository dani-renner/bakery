using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Menu.Models;

namespace Menu.TestTools
{
  [TestClass]
  public class MenuTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceofBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread),newBread.GetType());
    }
    [TestMethod]
    public void PastryConstructor_CreatesInstanceofPastry_Pastry()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry),newPastry.GetType());
    }
    [TestMethod]
    public void BreadTotalCalculator_TotalsCost_Bread()
    {
      Bread newBread = new Bread(4);
      Assert.AreEqual(80, newBread.BreadTotal(4));
    }
  }
}