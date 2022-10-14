using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Library;
using System.Diagnostics;
using System.Runtime.Remoting;
using System.Collections.Generic;

namespace Calculator.Library.Tests
{
    [TestClass]
    public class CalculatorAssertTest
    {
        [TestMethod]
        public void AreEqual()
        {
            // Arrange
            double expected = 25;
            double actual = Math.Pow(5, 2);

            // Assert
            // Assert - Check Actual v/s expected.
            Assert.AreEqual(expected, actual, "{0} Power {1} is 25", 5, 2);
        }

    
    [TestMethod]
    public void AreSame()
    {
        Customer c1 = new Customer() { Firstname = "David", lastName ="John" };
        Customer c2 = new Customer() { Firstname = "David", lastName = "John" };
        Assert.IsTrue(AreObjectPropertiesEqual(c1,c2));
    }

        private static bool AreObjectPropertiesEqual(Customer expected, Customer actual)
        {
            return expected.Firstname == actual.Firstname &&
                expected.lastName == actual.lastName;
        }
    
    [TestMethod]
    public void StringCollectionTest()
    {
        List<String> collection1 = new List<String>();
        collection1.Add("John");
        collection1.Add("Mike");
        collection1.Add("Pam");

        List<String> collection2 = new List<String>();
        collection2.Add("John");
        collection2.Add("Mike");
        collection2.Add("Pam");

        CollectionAssert.AreEqual(collection1, collection2);
    }

        [TestMethod]
        public void ComplexStringCollectionTest()
        {
            List<String> collection1 = new List<String>();
            collection1.Add("John");
            collection1.Add("Mike");
            collection1.Add("Pam");

            List<String> collection2 = new List<String>();
            collection2.Add("John");
            collection2.Add("Mike");
            collection2.Add("Pam");

            CollectionAssert.AreEqual(collection1, collection2);
        }

    }
}