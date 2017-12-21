using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_001_MethodsAndParametersModifiers2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verwendung von out parameters
            int Total;
            int Product;

            int i = 10;
            int j = 15;

            Calculate(i, j, out Total, out Product);
            Console.WriteLine($"Total is {Total} and Product is {Product}");

            Console.WriteLine();
            Console.WriteLine("Optionale Parameter mittels Parameterarray");
            AddNumbers(i, j);
            Console.WriteLine();
            AddNumbers(i, j, 20, 30, 50, 25);

        }

        static void Calculate(int i, int j, out int Sum, out int Product)
        {
            Sum = i + j;
            Product = i * j;
        }

        static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    result += number;
                }
            }
            Console.WriteLine($"Sum = {result}");
        }
    }
}
