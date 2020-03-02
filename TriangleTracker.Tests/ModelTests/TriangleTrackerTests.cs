using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace ProjectName.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    public void IsTriangle_NotTriangle_StringNotATriangle()
    {
      
      Assert.AreEqual("not a triangle", Triangle.IsTriangle(4,4,8));
    }
    [TestMethod]
    public void IsTriangle_Equilateral_StringEquilateral()
    {

      Assert.AreEqual("equilateral", Triangle.IsTriangle(3,3,3));
    }
    [TestMethod]
    public void IsTriangle_Isoceles_StringIsoceles()
    {

      Assert.AreEqual("isoceles", Triangle.IsTriangle(4, 4, 6));
    }
    [TestMethod]
    public void IsTriangle_Scalene_StringScalene()
    {

      Assert.AreEqual("scalene", Triangle.IsTriangle(2, 3, 4));
    }
  }
}