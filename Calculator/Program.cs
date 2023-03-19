using Calculator.Services;
using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            double result = operations.Add(5, 10);
            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }
    }
}
