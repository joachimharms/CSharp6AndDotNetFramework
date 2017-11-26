using System;
using System.Windows;

namespace BasicConsoleIO
{
    internal class Program
    {
        private static void DisplayMessage()
        {
            // Verwendung von String Format in einer WPF MessageBox:
            var userMessage = string.Format($"100000 in hex is {100000:x}");

            // You need to reference PresentationFramework.dll
            // in order to compile this line of code:
            MessageBox.Show(userMessage);
        }

        // Make use of some format tags.
        private static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine($"c format: {99999:C}");
            Console.WriteLine($"d9 format: {99999:D9}");
            Console.WriteLine($"f3 format: {99999:F3}");
            Console.WriteLine($"n format: {999999:N}");

            // Notice that upper- or lowercasing for hex
            // determines if letters are upper- or lowercase.
            Console.WriteLine($"E format: {99999:E}");
            Console.WriteLine($"e format: {99999:e}");
            Console.WriteLine($"X format: {99999:X}");
            Console.WriteLine($"x format: {99999:x}");
        }

        private static void GetUserData()
        {
            // Get name and age.
            Console.WriteLine("Please enter your name: ");
            var userName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            var userAge = Console.ReadLine();

            // Change echo color, just for fund.
            var prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            // Echo to the console.
            Console.WriteLine($"Hello {userName}! You are {userAge} years old.");

            // Restore previous color.
            Console.ForegroundColor = prevColor;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("*****Basic Console I/O*****");
            GetUserData();
            Console.WriteLine();

            FormatNumericalData();
            Console.WriteLine();

            DisplayMessage();
            Console.ReadLine();
        }
    }
}