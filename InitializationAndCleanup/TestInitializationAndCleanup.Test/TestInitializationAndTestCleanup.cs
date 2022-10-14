using System;
using InitializationAndCleanup;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace TestInitializationAndCleanup.Test
 
{
    [TestClass]
    public class TestInitializationAndTestCleanup
    {
        RectangleClass rectangle = new RectangleClass();

        [TestInitialize]
        public void Setup()
        {

            rectangle.Length = 3;
            rectangle.Width = 4;
        }

        [TestCleanup]
        public void Cleanup()
        {
          // rectangle null;
        }

        [TestMethod]
        public void PerimeterTest()
        {
            double expected = 14;
            double actual = rectangle.Perimeter();
            Assert.AreEqual(expected, actual);
        }

        public void AreaTest()
        {
            double expected = 12;
            double actual = rectangle.Area();
            Assert.AreEqual(expected, actual);
        }
    }
}