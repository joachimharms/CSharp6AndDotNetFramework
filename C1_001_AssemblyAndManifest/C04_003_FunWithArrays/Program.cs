using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_003_FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");
            SimpleArrays();
            Console.ReadLine();
            Console.WriteLine();

            ArrayInitialization();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Create an array of ints containing 3 elements indexed 0, 1, 2
            int[] myInts = new int[3];
            // Create a 100 item string array, indexed 0 - 99
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }

        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization.");
            // Array initialization syntax using the new keyword.
            string[] stringArray = new string[]
                                       { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);
            // Array initialization syntax without using the new keyword.
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);
            // Array initialization with new keyword and size.
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }
    }
}
