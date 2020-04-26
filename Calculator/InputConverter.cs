using System;
namespace Calculator
{
    public class InputConverter
    {
        public double ConvertInputToNum(string argTextInput)
        {
            double convertedNum;
            if (!double.TryParse(argTextInput, out convertedNum))
            {
                throw new ArgumentException("Expected a numeric value.");
            } else
            {
                return convertedNum;
            }
        }
    }
}
