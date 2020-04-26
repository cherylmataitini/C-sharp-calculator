using System;
namespace Calculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperator, double argFirstNum, double argSecondNum)
        {
            double result;

            switch (argOperator.ToLower())
            {
                case "add":  // in the case that the argOperator is "add" etc.
                case "+":
                case "plus":
                    result = argFirstNum + argSecondNum;
                    break;

                case "divide":
                case "/":
                    result = argFirstNum / argSecondNum;
                    break;

                case "multiply":
                case "times":
                case "*":
                    result = argFirstNum * argSecondNum;
                    break;

                case "subtract":
                case "minus":
                case "-":
                    result = argFirstNum - argSecondNum;
                    break;

                default:
                    throw new InvalidOperationException("Specified operation is not recognised");
            }

            return result;
        }
    }
}
