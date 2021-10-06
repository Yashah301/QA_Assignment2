using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QA_Assignment2;

namespace RectangleTest_A2
{
    [TestClass]
    public class RectangleUnitTest
    {
        [TestMethod]
        public void TestDefaultConstructor_defaultValue()
        {
            Rectangle rTest = new Rectangle();

            int h = rTest.Length;
            int w = rTest.Width;


            Assert.AreEqual(1, h);
            Assert.AreEqual(1, w);
        }

        [TestMethod]
        public void TestparameterizedConstructor_setGivenValue()
        {
            Rectangle rTest = new Rectangle(5,10);

            int h = rTest.Length;
            int w = rTest.Width;


            Assert.AreEqual(10, h);
            Assert.AreEqual(5, w);
        }
        [TestMethod]
        public void TestRectangleArea_withDefaultConstructor()
        {
            Rectangle rTest = new Rectangle();

            var rArea = rTest.getArea();

            Assert.AreEqual(1, rArea);
        }

        [TestMethod]
        public void TestRectangleArea_withParameterizedConstructor()
        {
            Rectangle rTest = new Rectangle(5, 5);

            var rArea = rTest.getArea();

            Assert.AreEqual(25, rArea);
        }

        [TestMethod]
        public void TestRectanglePerimeter_withDefaultConstructor()
        {
            Rectangle rTest = new Rectangle();

            var rPerimeter = rTest.getPerimeter();

            Assert.AreEqual(4, rPerimeter);
        }

        [TestMethod]
        public void TestRectanglePerimeter_withParameterizedConstructor()
        {
            Rectangle rTest = new Rectangle(5, 5);

            var rPerimeter = rTest.getPerimeter();

            Assert.AreEqual(20, rPerimeter);
        }

        [TestMethod]
        public void TestRectangle_getLength()
        {
            Rectangle rTest = new Rectangle(100,20);

            int l = rTest.Length;

            Assert.AreEqual(20, l);
        }

        [TestMethod]
        public void TestRectangle_getWidth()
        {
            Rectangle rTest = new Rectangle(100, 20);

            int w = rTest.Width;

            Assert.AreEqual(100, w);
        }

        [TestMethod]
        public void TestparameterizedConstructor_setNegetiveWidth()
        {
            Rectangle rTest = new Rectangle(-5, 5);

            int h = rTest.Length;
            int w = rTest.Width;

            Assert.AreEqual(5, h);
            Assert.AreEqual(1, w);
        }

        [TestMethod]
        public void TestparameterizedConstructor_setNegetiveHeight()
        {
            Rectangle rTest = new Rectangle(10, -5);

            int h = rTest.Length;
            int w = rTest.Width;

            Assert.AreEqual(1, h);
            Assert.AreEqual(10, w);
        }
    }
}
