using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter(); // bc we need access to InputConverter class

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            // set up data
            string inputNumber = "5";

            // process data
            double convertedNumber = _inputConverter.ConvertInputToNum(inputNumber);

            // compare to assumption
            Assert.AreEqual(5, convertedNumber);
        }


        // This test succeeds when an Exception of type ArgumentException is thrown.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))] // another attribute - this test has to throw an exception & has to be of type ArgumentException (coming from the InputConverter class Exception)
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "*"; // a symbol that just won't convert
            double convertedNumber = _inputConverter.ConvertInputToNum(inputNumber);

        }
    }
}