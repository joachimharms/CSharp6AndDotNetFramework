using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_001_MethodsAndParameterModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Methods *****\n");
            // Pass two variables in by value.
            int x = 9, y = 10;
            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is: {0}", Add(x, y));
            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
            Console.ReadLine();
            Console.WriteLine();

            // No need to assign initial value to local variables
            // used as output parameters, provided the first time
            // you use them is as output arguments.
            int ans;
            Add(90, 90, out ans);
            Console.WriteLine("90 + 90 = {0}", ans);
            Console.ReadLine();

            
                Console.WriteLine("***** Fun with multiple out modifiers *****");
           
                int i; string str; bool b;
                FillTheseValues(out i, out str, out b);
                Console.WriteLine("Int is: {0}", i);
                Console.WriteLine("String is: {0}", str);
                Console.WriteLine("Boolean is: {0}", b);
                Console.ReadLine();


            Console.WriteLine("***** Fun with params *****");
            // Pass in a comma-delimited list of doubles…
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is: {0}", average);
            // …or pass an array of doubles.
            double[] data = { 4.0, 3.2, 5.7 };
            average = CalculateAverage(data);
            Console.WriteLine("Average of data is: {0}", average);
            // Average of 0 is 0!
            Console.WriteLine("Average of data is: {0}", CalculateAverage());
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("***** Fun with optional arguments *****");
            EnterLogData("Oh no! Grid can't find data");
            EnterLogData("Oh no! I can't find the payroll data", "CFO");
            Console.ReadLine();

            Console.WriteLine("***** Fun with named arguments *****");
            DisplayFancyMessage(ConsoleColor.Blue, ConsoleColor.Yellow, "Es ist sehr bunt");

            // Argumenteübergabe mittels benannten Argumente mit : Dadurch beliebige Reihenfolge der Übergabe:
            DisplayFancyMessage(message: "Wow! Very Fancy indeed!",
                textColor: ConsoleColor.DarkRed,
                backgroundColor: ConsoleColor.White);
            DisplayFancyMessage(backgroundColor: ConsoleColor.Green,
                message: "Testing...",
                textColor: ConsoleColor.DarkBlue);
            Console.ReadLine();
        }

        // Arguments are passed by value by default.
        static int Add(int x, int y)
        {
            int ans = x + y;
            // Caller will not see these changes
            // as you are modifying a copy of the
            // original data.
            x = 10000;
            y = 88888;
            return ans;
        }

        // Output parameters must be assigned by the called method.
        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        // Returning multiple output parameters.
        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        // Return average of "some number" of doubles.
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }
        
        // Optionale Argumente - dem Parameter owner wird ein Wert zugewiesen, dadurch wird er optional: 
        static void EnterLogData(string message, string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
        }

        //// Error! The default value for an optional arg must be known
        //// at compile time!
        //static void EnterLogData(string message,
        //                         string owner = "Programmer", DateTime timeStamp = DateTime.Now)
        //{
        //    Console.Beep();
        //    Console.WriteLine("Error: {0}", message);
        //    Console.WriteLine("Owner of Error: {0}", owner);
        //    Console.WriteLine("Time of Error: {0}", timeStamp);
        //}

        static void DisplayFancyMessage(ConsoleColor textColor,
                                        ConsoleColor backgroundColor, string message)
        {
            // Store old colors to restore after message is printed.
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;
            // Set new colors and print message.
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            // Restore previous colors.
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }
    }
}
