using System;
using System.Collections.Generic;

class ArithemicExpressionCalculator
{
    static void Main()
    {
        Console.Write("Enter an arithmetic expression with + and - operators: ");
        string expression = Console.ReadLine();

        int result = CalculateArithmeticExpression(expession);
        Console.WriteLine("Result: " + result);
    }
}