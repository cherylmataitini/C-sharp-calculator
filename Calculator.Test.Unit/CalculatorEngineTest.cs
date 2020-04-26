using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine(); // bc we need access to CalculatorEngine class

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            // setting up the test data
            int number1 = 1;
            int number2 = 2;

            // processing data
            double result = _calculatorEngine.Calculate("add", number1, number2);

            // compare result against our assumption
            Assert.AreEqual(3, result);   // takes expected and actual result
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            // setting up the data
            int number1 = 1;
            int number2 = 2;

            // processing data
            double result = _calculatorEngine.Calculate("+", number1, number2);

            // compare result against our assumption
            Assert.AreEqual(3, result);   // takes expected and actual result
        }
    }
}
