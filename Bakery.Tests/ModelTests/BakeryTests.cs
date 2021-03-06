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
      Bread newBread = new Bread(2, 2);
      Assert.AreEqual(typeof(Bread),newBread.GetType());
    }
    [TestMethod]
    public void PastryConstructor_CreatesInstanceofPastry_Pastry()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry),newPastry.GetType());
    }
    [TestMethod]
    public void BreadDiscountCost_TotalsCost_Bread()
    {
      Bread newBread = new Bread(4, 4);
      Assert.AreEqual(35, newBread.BreadCost());
    }
    [TestMethod]
    public void BreadCost_TotalsCost_Bread()
    {
      Bread newBread = new Bread(1, 2);
      Assert.AreEqual(15, newBread.BreadCost());
    }  
    [TestMethod]
    public void PastryDiscountCalculator_TotalsCost_Pastry()
    {
      Pastry newBread = new Pastry(6);
      Assert.AreEqual(10, newBread.PastryCost());
    }
    [TestMethod]
    public void PastryCost_TotalsCost_Pastry()
    {
      Pastry newBread = new Pastry(2);
      Assert.AreEqual(4, newBread.PastryCost());
    }
  }
}