using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SquareCalculator.Tests
{
    [TestClass]
    public class SquareCalculatorTests
    {
        [TestMethod]
        public void NegativeCircleTest()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Circle(-2));
        }

        [TestMethod]
        public void NegativeTriangleTest()
        {
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Triangle(-2,3,1));            
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => new Triangle(0,3,10));
        }

        [TestMethod]
        public void TriangleExistsTest()
        {
            Triangle triangle = new Triangle(3, 1, 6);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => triangle.GetSquare());
        }

        [TestMethod]
        public void CircleSquareTest()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(25*Math.PI,circle.GetSquare());
        }

        //[TestMethod]
        //public void NegativeTriangleSquare()
        //{
        //    Triangle triangle = new Triangle(3, 1, 6);
        //    Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => triangle.GetSquare());
        //}

        [TestMethod]
        public void TriangleSquareTest()
        {
            Triangle triangle = new Triangle(3, 5, 4);
            Assert.AreEqual(6, new Triangle(3, 5, 4).GetSquare());
            Assert.AreEqual(0, new Triangle(3, 1, 2).GetSquare());
        }

        [TestMethod]
        public void TriangleIsRightTest1()
        {
            Assert.AreEqual(true, new Triangle(3,5,4).IsRightTriangle());
            Assert.AreEqual(false, new Triangle(4,6,8).IsRightTriangle());
        }

    }
}
