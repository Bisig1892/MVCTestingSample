using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCTestingSample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCTestingSample.Models.Tests
{
    [TestClass()]
    public class ValidationHelperTests
    {
        [TestMethod()]
        [DataRow("9.99")]
        [DataRow("$20.00")] // Works with US currency only
        [DataRow(".99")]
        [DataRow("0.99")]
        [DataRow("0")]
        public void IsValidPrice_ValidPrice_ReturnsTrue(string input)
        {
            bool result = ValidationHelper.IsValidPrice(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow(" ")]
        public void IsValidPrice_InvalidPrice_ReturnFalse(string input)
        {
            bool result = ValidationHelper.IsValidPrice(input);
            Assert.IsFalse(result);
        }
    }
}