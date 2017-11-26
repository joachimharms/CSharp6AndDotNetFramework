﻿using System;
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

            NewingDataTypes();
            Console.WriteLine();

            ObjectFunctionality();

        }

        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool(); // Set to false.
            int i = new int(); // Set to 0.
            double d = new double(); // Set to 0.
            DateTime dt = new DateTime(); // Set to 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }

        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");
            // A C# int is really a shorthand for System.Int32,
            // which inherits the following members from System.Object.
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }
    }

}