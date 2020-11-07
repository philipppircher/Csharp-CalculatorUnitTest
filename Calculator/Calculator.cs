using System;

namespace CalculatorProject
{
    public enum CalculationType
    {
        ADDITION,
        SUBTRACTION,
        MULTIPLICATION,
        DIVISION
    }

    public class Calculator
    {
        public decimal ChfToEur { get { return 0.94m; } }
        public decimal Calculate(decimal value1, decimal value2, CalculationType calculationType)
        {
            switch (calculationType)
            {
                case CalculationType.ADDITION:
                    return MakeAddition(value1, value2);

                case CalculationType.SUBTRACTION:
                    return MakeSubtraction(value1, value2);

                case CalculationType.MULTIPLICATION:
                    return MakeMulitplication(value1, value2);

                case CalculationType.DIVISION:
                    return MakeDivision(value1, value2);

                default:
                    throw new NotImplementedException($"Calculation {calculationType} is not implemented!");
            }
        }

        private decimal MakeAddition(decimal value1, decimal value2)
        {
            return value1 + value2;
        }

        private decimal MakeSubtraction(decimal value1, decimal value2)
        {
            return value1 - value2;
        }
        private decimal MakeMulitplication(decimal value1, decimal value2)
        {
            return value1 * value2;
        }
        private decimal MakeDivision(decimal value1, decimal value2)
        {
            return value1 / value2;
        }

        public decimal GetChfToEuro(int chf)
        {
            return chf * ChfToEur;
        }
    }
}
