using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_005_FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Structures *****\n");
            // Create an initial Point.
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();
            // Adjust the X and Y values.
            myPoint.Increment();
            myPoint.Display();
            Console.ReadLine();

            // Error! Did not assign Y value.
            Point p1;
            p1.X = 10;
            ////Folgende Methode kann nicht aufgerufen werden, da p1.Y noch nicht initialisiert wurde:
            //p1.Display(); 

            // OK! Both fields assigned before use.
            Point p2;
            p2.X = 10;
            p2.Y = 10;
            p2.Display();
            Console.WriteLine();

            Console.WriteLine("Alle Felder werden auf default Werte gesetzt durch Aufruf default Konstruktor:");
            // Set all fields to default values
            // using the default constructor.
            Point p3 = new Point();
            // Prints X=0,Y=0.
            p3.Display();
            Console.WriteLine();

            Console.WriteLine("Aufruf eines custom parameterisierten Konstruktors: ");
            // Call custom constructor.
            Point p4 = new Point(50, 60);
            // Prints X=50,Y=60.
            p4.Display();
        }

        struct Point
        {
            // Fields of the structure.
            public int X;
            public int Y;
            // Add 1 to the (X, Y) position.
            public void Increment()
            {
                X++; Y++;
            }
            // Subtract 1 from the (X, Y) position.
            public void Decrement()
            {
                X--; Y--;
            }
            // Display the current position.
            public void Display()
            {
                Console.WriteLine("X = {0}, Y = {1}", X, Y);
            }


            // A custom constructor.
            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }
        }
    }
}
