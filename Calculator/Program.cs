using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.mathAddition(54, 29));
            Console.WriteLine(calc.mathSubtraction(54, 29));
            Console.WriteLine(calc.mathMultipy(54, 29));
            Console.WriteLine(calc.mathDivide(54, 29));
        }
    }
}
