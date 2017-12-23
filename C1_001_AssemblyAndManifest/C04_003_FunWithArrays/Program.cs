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

            Console.WriteLine("Array Intialisierung mittels Array-Initialisierungssyntax");
            ArrayInitialization();
            Console.WriteLine();

            Console.WriteLine("Implizite typisierte Arrayinitialisierung:");
            DeclareImplicitArrays();
            Console.WriteLine();

            Console.WriteLine("Array von Objekten kann jeden Typen halten:");
            ArrayOfObjects();
            Console.WriteLine();

            Console.WriteLine("Rechtwinkliges Array:");
            RectMultidimensionalArray();
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

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");
            // a is really int[].
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());
            // b is really double[].
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());
            // c is really string[].
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");
            // An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";
            foreach (object obj in myObjects)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            // A rectangular MD array.
            int[,] myMatrix;
            myMatrix = new int[3, 4];
            // Populate (3 * 4) array.
            for (int i = 0; i < 3; i++)
            for (int j = 0; j < 4; j++)
                myMatrix[i, j] = i * j;
            // Print (3 * 4) array.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
