using CalculatorProject;
using System;

namespace CalculatorProject
{
    class Program
    {
        enum CalculationType { Addition, Subtraction, Multiplication, Division};

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Taschenrechner App");

            Console.Write("1. Zahl: ");
            string val1Input = Console.ReadLine();

            Console.Write("2. Zahl: ");
            string val2Input = Console.ReadLine();

            Console.Write("Operator: ");
            string operation = Console.ReadLine();

            decimal.TryParse(val1Input, out var number1);
            decimal.TryParse(val2Input, out var number2);

            CalculationType? calculationType = null;

            switch (operation)
            {
                case "+":
                    calculationType = CalculationType.Addition;
                    break;
                case "-":
                    calculationType = CalculationType.Subtraction;
                    break;
                case "*":
                    calculationType = CalculationType.Multiplication;
                    break;
                case "/":
                    calculationType = CalculationType.Division;
                    break;
            }

            if (calculationType.HasValue)
                Console.WriteLine(calc.Calculate(number1, number2, (CalculatorProject.CalculationType)calculationType.Value));
        }   
    }
}
