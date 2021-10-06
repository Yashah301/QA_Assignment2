using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QA_Assignment2;

namespace RectangleTest_A2
{
    [TestClass]
    public class RectangleUnitTest
    {
        [TestMethod] // Case to test default constructor 
        public void TestDefaultConstructor_defaultValue() 
        {
            // Rectangle obj
            Rectangle rTest = new Rectangle();

            int h = rTest.Length;
            int w = rTest.Width;

            // asserting
            Assert.AreEqual(1, h);
            Assert.AreEqual(1, w);
        }

        [TestMethod] // Case to test non-default constructor 
        public void TestparameterizedConstructor_setGivenValue()
        {
            Rectangle rTest = new Rectangle(5,10);

            int h = rTest.Length;
            int w = rTest.Width;


            Assert.AreEqual(10, h);
            Assert.AreEqual(5, w);
        }
        [TestMethod] // Case to test Reactangle Area with Default constructor 
        public void TestRectangleArea_withDefaultConstructor()
        {
            Rectangle rTest = new Rectangle();

            var rArea = rTest.getArea();

            Assert.AreEqual(1, rArea);
        }

        [TestMethod] // Case to test Reactangle Area with non-Default constructor 
        public void TestRectangleArea_withParameterizedConstructor()
        {
            Rectangle rTest = new Rectangle(5, 5);

            var rArea = rTest.getArea();

            Assert.AreEqual(25, rArea);
        }

        [TestMethod] // Case to test Reactangle Perimeter with Default constructor 
        public void TestRectanglePerimeter_withDefaultConstructor()
        {
            Rectangle rTest = new Rectangle();

            var rPerimeter = rTest.getPerimeter();

            Assert.AreEqual(4, rPerimeter);
        }

        [TestMethod] // Case to test Reactangle Perimeter with non-Default constructor 
        public void TestRectanglePerimeter_withParameterizedConstructor()
        {
            Rectangle rTest = new Rectangle(5, 5);

            var rPerimeter = rTest.getPerimeter();

            Assert.AreEqual(20, rPerimeter);
        }

        [TestMethod] // case to test getting rectangle length
        public void TestRectangle_getLength()
        {
            Rectangle rTest = new Rectangle(100,20);

            int l = rTest.Length;

            Assert.AreEqual(20, l);
        }

        [TestMethod] // case to test getting rectangle width
        public void TestRectangle_getWidth()
        {
            Rectangle rTest = new Rectangle(100, 20);

            int w = rTest.Width;

            Assert.AreEqual(100, w);
        }

        [TestMethod] // case to test setting negative width
        public void TestparameterizedConstructor_setNegativeWidth()
        {
            Rectangle rTest = new Rectangle(-5, 5);

            int h = rTest.Length;
            int w = rTest.Width;

            Assert.AreEqual(5, h);
            Assert.AreEqual(1, w);
        }

        [TestMethod] // case to test setting negative Length
        public void TestparameterizedConstructor_setNegativeLength()
        {
            Rectangle rTest = new Rectangle(10, -5);

            int h = rTest.Length;
            int w = rTest.Width;

            Assert.AreEqual(1, h);
            Assert.AreEqual(10, w);
        }

        [TestMethod] // case to test overwritting the width
        public void TestReactangle_overwriteWidth()
        {
            Rectangle rTest = new Rectangle();
            // Old Value
            rTest.Width = 5;
            // New Value
            rTest.Width = 50;

            Assert.AreEqual(50, rTest.Width);
        }

        [TestMethod] // case to test overwritting the Length
        public void TestReactangle_overwriteLength()
        {
            Rectangle rTest = new Rectangle();
            // Old Value
            rTest.Length = 5;
            // New Value
            rTest.Length = 50;

            Assert.AreEqual(50, rTest.Length);
        }

    }
}
