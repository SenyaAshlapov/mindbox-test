using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FiguresSquare;

namespace FiguresSquareTests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void TestCircleCalculateSquare()
        {
            float radius = 6;
            float exceptedCircleSquare = 113.0F;

            Circle testCircle = new Circle(radius);

            float calculatedSquare = testCircle.CalculateSquare();

            Assert.AreEqual(exceptedCircleSquare, calculatedSquare, "Circle CalculateSquare not correct");

        }

        [TestMethod]
        public void TestTriangleCalculateSquare()
        {
            float side_1 =5, side_2 = 12, side_3 = 13;
            float exceptedTriangleSquare = 30F;

            Triangle testTriangle = new Triangle(side_1, side_2, side_3);

            float calculatedSquare = testTriangle.CalculateSquare();
            bool calculatedIsRightTriangle = testTriangle.CheckTriangle();

            Assert.AreEqual(exceptedTriangleSquare, calculatedSquare, "Triangle CalculateSquare not correct");
            Assert.AreEqual(calculatedIsRightTriangle, true, "Triangle CheckTriangle not correct");

        }
    }
}
