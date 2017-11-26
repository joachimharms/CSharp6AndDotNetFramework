using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_003_BasicDataTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclarations();
        }

        public static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Date Declarations");

            // Local variables are declared so:
            // dataType varName = initialValue;
            int myInt = 0;

            // You can also declare and assign on two lines.
            string myString;
            myString = "This is my character data.";

            // Declare 3 bools on a single line.
            bool b1 = true, b2 = false, b3 = b1;

            // Use System.Boolean data type to declare a bool.
            System.Boolean b4 = false;

            Console.WriteLine($"Your Data: {myInt}, {myString}, {b1}, {b2}, {b3}, {b4}");
            Console.WriteLine();
        }
    }

}
