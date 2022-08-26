using ApplicationCore.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [DataRow(5, 2, 7)]
        [DataRow(5, 5, 10)]
        public void SumValues(int num1, int num2, int expectedResult)
        {
            //
            // TODO: Add test logic here
            //
            var sum = new Sum();
            var result = sum.SumValues(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
