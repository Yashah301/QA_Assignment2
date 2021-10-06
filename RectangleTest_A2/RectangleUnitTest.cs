using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QA_Assignment2;

namespace RectangleTest_A2
{
    [TestClass]
    public class RectangleUnitTest
    {
        [TestMethod] // Case to test default constructor 
        public void DefaultConstructor_defaultValues_EqualsOne() 
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
        public void ParameterizedConstructor_setGivenValue_EqualsGivenValue()
        {
            Rectangle rTest = new Rectangle(5,10);

            int h = rTest.Length;
            int w = rTest.Width;


            Assert.AreEqual(10, h);
            Assert.AreEqual(5, w);
        }
        [TestMethod] // Case to test Reactangle Area with Default constructor 
        public void RectangleArea_CalculateArea_withDefaultConstructor()
        {
            Rectangle rTest = new Rectangle();

            var rArea = rTest.getArea();

            Assert.AreEqual(1, rArea);
        }

        [TestMethod] // Case to test Reactangle Area with non-Default constructor 
        public void RectangleArea_CalculateArea_withParameterizedConstructor()
        {
            Rectangle rTest = new Rectangle(5, 5);

            var rArea = rTest.getArea();

            Assert.AreEqual(25, rArea);
        }

        [TestMethod] // Case to test Reactangle Perimeter with Default constructor 
        public void RectanglePerimeter_CalculatePerimeter_withDefaultConstructor()
        {
            Rectangle rTest = new Rectangle();

            var rPerimeter = rTest.getPerimeter();

            Assert.AreEqual(4, rPerimeter);
        }

        [TestMethod] // Case to test Reactangle Perimeter with non-Default constructor 
        public void RectanglePerimeter_CalculatePerimeter_withParameterizedConstructor()
        {
            Rectangle rTest = new Rectangle(5, 5);

            var rPerimeter = rTest.getPerimeter();

            Assert.AreEqual(20, rPerimeter);
        }

        [TestMethod] // case to test getting rectangle length
        public void Rectangle_GetLength_ReturnsRectangleLenght()
        {
            Rectangle rTest = new Rectangle(100,20);

            int l = rTest.Length;

            Assert.AreEqual(20, l);
        }

        [TestMethod] // case to test getting rectangle width
        public void TestRectangle_GetWidth_ReturnsRectangleWidth()
        {
            Rectangle rTest = new Rectangle(100, 20);

            int w = rTest.Width;

            Assert.AreEqual(100, w);
        }

        [TestMethod] // case to test setting negative width
        public void ParameterizedConstructor_setvalueToOne_IfNegativeWidthValue()
        {
            Rectangle rTest = new Rectangle(-5, 5);

            int h = rTest.Length;
            int w = rTest.Width;

            Assert.AreEqual(5, h);
            Assert.AreEqual(1, w);
        }

        [TestMethod] // case to test setting negative Length
        public void ParameterizedConstructor_setvalueToOne_IfNegativeLengthValue()
        {
            Rectangle rTest = new Rectangle(10, -5);

            int h = rTest.Length;
            int w = rTest.Width;

            Assert.AreEqual(1, h);
            Assert.AreEqual(10, w);
        }

        [TestMethod] // case to test overwritting the width
        public void Reactangle_overwriteWidth_newWidth()
        {
            Rectangle rTest = new Rectangle();
            // Old Value
            rTest.Width = 5;
            // New Value
            rTest.Width = 50;

            Assert.AreEqual(50, rTest.Width);
        }

        [TestMethod] // case to test overwritting the Length
        public void TestReactangle_overwriteLength_newLength()
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
