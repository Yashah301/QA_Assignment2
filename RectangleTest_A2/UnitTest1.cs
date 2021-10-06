using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using QA_Assignment2;

namespace RectangleTest_A2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDefaultConstructor()
        {
            Rectangle rTest = new Rectangle();

            int h = rTest.Height;
            int w = rTest.Width;


            Assert.AreEqual(1, h);
            Assert.AreEqual(1, w);
        }

    }
}
