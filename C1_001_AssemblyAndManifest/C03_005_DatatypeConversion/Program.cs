using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_005_DatatypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");
            // Add two shorts and print the result.
            Console.WriteLine("Implicit casting short to int:");
            short numb1 = 9, numb2 = 10;
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));
            Console.ReadLine();
            Console.WriteLine();

            //// Compiler error below because of overflow of datatype!
            //Console.WriteLine("Compiler Error: Overflow of datatype short");
            //numb1 = 30000;
            //numb2 = 30000;
            //short answer = Add(numb1, numb2);
            //Console.WriteLine("{0} + {1} = {2}",
            //    numb1, numb2, answer);
            //Console.ReadLine();

            //// Another compiler error!
            //NarrowingAttempt();


            Console.WriteLine("Explizites Casting und erlaube Datenverlust dabei (Führt zu einem Stackoverflow):");
            numb1 = 30000;
            numb2 = 30000;
            // Explicitly cast the int into a short (and allow loss of data).
            short answer = (short)Add(numb1, numb2);
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
            NarrowingAttempt();
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Explizites Casting von int in short - ohne Datenverlust und ohne Stackoverflow: ");
            NarrowingAttempt();
            Console.WriteLine();

            Console.WriteLine("Provoziere Überlauf - richtiges Ergebnis wäre 350:");
            ProcessBytes();
            Console.WriteLine();

            Console.WriteLine("Provoziere Überlauf - diesmal abgefangen durch keyword checked:");
            // This time, tell the compiler to add CIL code
            // to throw an exception if overflow/underflow
            // takes place.
            ProcessBytesChecked();
            Console.WriteLine();

            Console.WriteLine("Provoziere Überlauf - diesmal abgefangen durch keyword checked mit größerem scope über ganzen Codeblock");
            ProcessBytesChecked2();
            Console.WriteLine();

            Console.WriteLine("Provozier Überlauf - diesmal wird explizit nicht auf Überlauf geprüft:");
            ProcessBytesUnchecked();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        //static void NarrowingAttempt()
        //{
        //    byte myByte = 0;
        //    int myInt = 200;
        //    //myByte = myInt;
        //    Console.WriteLine("Value of myByte: {0}", myByte);
        //}

        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;
            // Explicitly cast the int into a byte (no loss of data).
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;
            byte sum = (byte)Add(b1, b2);
            // sum should hold the value 350. However, we find the value 94!
            Console.WriteLine("sum = {0}", sum);
        }

        static void ProcessBytesChecked()
        {
            byte b1 = 100;
            byte b2 = 250;

            // This time, tell the compiler to add CIL code
            // to throw an exception if overflow/underflow
            // takes place.
            try
            {
                byte sum = checked((byte)Add(b1, b2));
                Console.WriteLine("sum = {0}", sum);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ProcessBytesChecked2()
        {
            byte b1 = 100;
            byte b2 = 250;

            try
            {
                checked
                {
                    byte sum = (byte)Add(b1, b2);
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ProcessBytesUnchecked()
        {
            byte b1 = 100;
            byte b2 = 250;
            // Assuming /checked is enabled,
            // this block will not trigger
            // a runtime exception.
            unchecked
            {
                byte sum = (byte)(b1 + b2);
                Console.WriteLine("sum = {0} ", sum);
            }
        }
    }
}
