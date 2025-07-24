using System;
using CalculatorApp.Services;

class Program
{
    static void Main()
    {
        var calc = new CalculatorService();

        while (true)
        {
            Console.WriteLine("==== Simple Calculator ====");
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation: + - * /");
            string op = Console.ReadLine();

            try
            {
                double result = 0;
                switch (op)
                {
                    case "+": result = calc.Add(a, b); break;
                    case "-": result = calc.Subtract(a, b); break;
                    case "*": result = calc.Multiply(a, b); break;
                    case "/": result = calc.Divide(a, b); break;
                    default:
                        Console.WriteLine("Invalid operation");
                        continue;
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Do you want to calculate again? (y/n):");
            var choice = Console.ReadLine();
            if (choice?.ToLower() != "y")
                break;
        }
    }
}
