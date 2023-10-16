using Assignment13;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace Assignment13Tests
{
    [TestClass]
    public class UnitTest1
    {
        [Test]
        public void TestSum()
        {
            // Arrange
            int a = 5;
            int b = 3;
            int expectedSum = 8;

            // Act
            int actualSum = Program.sum(a, b);

            // Assert
            Assert.AreEqual(expectedSum, actualSum, "Sum of a and b is not as expected.");
        }
    }
}


