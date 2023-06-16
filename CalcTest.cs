using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyTestProject
{
    [TestFixture]
    class CalcTest
    {
        [Test]
        public void AddTest()
        {
            Calc c = new Calc();
            double x = 4.0;
            double y = 5.0;
            double expectedValue = 9.0;
            double actualValue = c.Add(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void SubtractTest()
        {
            Calc c = new Calc();
            double x = 10.0;
            double y = 6.0;
            double expectedValue = 4.0;
            double actualValue = c.Subtract(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void CircleAreaTest() 
        {
            Circle c = new Circle();
            double radius = 10;
            double expectedValue = 314.16;
            double actualValue = c.CircleArea(radius);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void CirclePerimeterTest() 
        {
            Circle c = new Circle();
            double radius = 10;
            double expectedValue = 62.83;
            double actualValue = c.CirclePerimeter(radius);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void RectangleAreaTest()
        {
            Rectangle r = new Rectangle();
            double height = 5;
            double width = 10;
            double expectedValue = 50;
            double actualValue = r.RectangleArea(height, width);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void RectanglePerimeterTest()
        {
            Rectangle r = new Rectangle();
            double height = 5;
            double width = 10;
            double expectedValue = 30;
            double actualValue = r.RectanglePerimeter(height, width);
            Assert.AreEqual(expectedValue, actualValue);

        }

        [Test]
        public void TriangleAreaTest() 
        {
            Triangle t = new Triangle();
            double sideA =  10;
            double sideB = 10;
            double sideC = 10;
            double expectedValue = 43.30;
            double actualValue = t.TriangleArea(sideA, sideB, sideC);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void TrianglePerimeterTest()
        {
            Triangle t = new Triangle();
            double sideA = 10;
            double sideB = 10;
            double sideC = 10;
            double expectedValue = 30;
            double actualValue = t.TrianglePerimeter(sideA, sideB, sideC);
            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}
