using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.mathAddition(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }

        public void SubtractTwoIntegers()
        {
           int sub = _calculator.mathSubtraction(400, 25);

           Assert.Equal(sub, 375);
        }

        public void MultiplyTwoIntegers()
        {
            int mult = _calculator.mathMultipy(14, 8);

            Assert.Equal(mult, 112);
        }

        public void DivideTwoIntegers()
        {
            int div = _calculator.mathDivide(225, 15);

            Assert.Equal(div, 15);
        }
    }
}
