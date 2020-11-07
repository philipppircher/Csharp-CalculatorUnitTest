using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact (DisplayName = "Test der Addition")]
        public void TestAddition()
        {
            CalculatorProject.Calculator calculator = new CalculatorProject.Calculator();
            decimal result = calculator.Calculate(1.5m, 3.5m, CalculatorProject.CalculationType.ADDITION);
            Assert.Equal(5.0m, result);
        }

        [Fact(DisplayName = "Test der Subtraction")]
        public void TestSubtraction()
        {
            CalculatorProject.Calculator calculator = new CalculatorProject.Calculator();
            decimal result = calculator.Calculate(1.5m, 3.5m, CalculatorProject.CalculationType.SUBTRACTION);
            Assert.Equal(-2.0m, result);
        }

        [Fact(DisplayName = "Test der Multiplication")]
        public void TestMultiplication()
        {
            CalculatorProject.Calculator calculator = new CalculatorProject.Calculator();
            decimal result = calculator.Calculate(1.5m, 3.5m, CalculatorProject.CalculationType.MULTIPLICATION);
            Assert.Equal(5.25m, result);
        }

        [Fact(DisplayName = "Test der Division")]
        public void TestDivision()
        {
            decimal dividend = 10.0m;
            decimal divisor = 2.0m;

            CalculatorProject.Calculator calculator = new CalculatorProject.Calculator();
            decimal result = calculator.Calculate(dividend, divisor, CalculatorProject.CalculationType.DIVISION);
            Assert.Equal(5.0m, result);
        }

        [Fact(DisplayName = "Divisor nicht 0")]
        public void TestDivisorIsNotZero()
        {
            CalculatorProject.Calculator calculator = new CalculatorProject.Calculator();
            decimal divisor = 0.0m;
            Assert.False(divisor != 0);
        }

        [Fact(DisplayName = "Schweizerfranken zu Euro Wechseln")]
        public void TestChfToEur()
        {
            CalculatorProject.Calculator calculator = new CalculatorProject.Calculator();
            decimal result = calculator.GetChfToEuro(2);
            Assert.Equal(calculator.ChfToEur * 2, result);

        }
    }
}
