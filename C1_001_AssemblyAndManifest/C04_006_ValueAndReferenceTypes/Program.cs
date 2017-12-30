using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_006_ValueAndReferenceTypes
{
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

    // Classes are always reference types.
    class PointRef
    {
        public int X;

        public int Y;
        // Same members as the Point structure...
        // Be sure to change your constructor name to PointRef!
        public PointRef(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }

        // Display the current position.
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }

    class ShapeInfo
    {
        public string infoString;
        public ShapeInfo(string info)
        {
            infoString = info;
        }
    }

    struct Rectangle
    {
        // The Rectangle structure contains a reference type member.
        public ShapeInfo rectInfo;
        public int rectTop, rectLeft, rectBottom, rectRight;
        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top; rectBottom = bottom;
            rectLeft = left; rectRight = right;
        }
        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
                              "Left = {3}, Right = {4}",
                rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Value and Reference Type");
            Console.WriteLine("Lokale Value types einer Methode poppen nach Aufruf der Methode vom stack\nund existieren nicht mehr:");
            LocalValueTypes();
            Console.WriteLine();

            Console.WriteLine("Valuetype Zuweisungen - die Werte werden nur kopiert: ");
            ValueTypeAssignment();
            Console.WriteLine();

            Console.WriteLine("Referenztypen Zuweisungen - die Adresse der Objekte auf dem Heap werden übergeben:");
            ReferenceTypeAssignment();
            Console.WriteLine();

            Console.WriteLine("Wertetyp beinhaltet eine Referenzvariable auf ein Objekt:");
            ValueTypeContainingRefType();
        }

        // Local structures are popped off
        // the stack when a method returns.
        static void LocalValueTypes()
        {
            // Recall! "int" is really a System.Int32 structure.
            int i = 0;
            // Recall! Point is a structure type.
            Point p = new Point();
        } // "i" and "p" popped off the stack here!


        // Assigning two intrinsic value types results in
        // two independent variables on the stack.
        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning value types\n");
            Point p1 = new Point(10, 10);
            Point p2 = p1;
            // Print both points.
            p1.Display();
            p2.Display();
            // Change p1.X and print again. p2.X is not changed.
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }

        static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning reference types\n");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;
            // Print both point refs.
            p1.Display();
            p2.Display();
            // Change p1.X and print again.
            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }

        static void ValueTypeContainingRefType()
        {
            // Create the first Rectangle.
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);
            // Now assign a new Rectangle to r1.
            Console.WriteLine("-> Assigning r2 to r1");
            Rectangle r2 = r1;
            // Change some values of r2.
            Console.WriteLine("-> Changing values of r2");
            r2.rectInfo.infoString = "This is new info!";
            r2.rectBottom = 4444;
            // Print values of both rectangles.
            r1.Display();
            r2.Display();
        }
    }
}
