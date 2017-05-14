using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApplication
{
    public class Calculator
    {
        public static int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }
    }

    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_Devide()
        {
            int expected = 5;
            int actual = Calculator.Divide(10, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}
