using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Basic Console I/O*****");
            GetUserData();
            Console.ReadLine();
        }

        private static void GetUserData()
        {
            // Get name and age.
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            string userAge = Console.ReadLine();

            // Change echo color, just for fund.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            // Echo to the console.
            Console.WriteLine($"Hello {userName}! You are {userAge} years old.");

            // Restore previous color.
            Console.ForegroundColor = prevColor;

        }
    }
}
