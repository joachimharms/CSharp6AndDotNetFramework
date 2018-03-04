using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_002_CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Ack! Illegal to allocate interface types.
            //IPointy p = new IPointy(); // Compiler error!

            Console.WriteLine("***** Fun with Interfaces *****\n");
            // Call Points property defined by IPointy.
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);
            Console.ReadLine();

            //// Hier prüfst mittel explizitem Casting in das Interface und mithilfe von Structured Exceptionhandling,
            //// ob der Typ das Interface implementiert hat. Dies ist nicht best Practice. Verwende as und is keyword stattdessen. Siehe weiteren Code.
            //// Catch a possible InvalidCastException.
            //Circle c = new Circle("Lisa");
            //IPointy itfPt = null;
            //try
            //{
            //    itfPt = (IPointy)c;
            //    Console.WriteLine(itfPt.Points);
            //}
            //catch (InvalidCastException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.ReadLine();

            //// Prüfe ob hex2 das Ínterface IPointy implementiert.
            //// Can we treat hex2 as IPointy?
            //Hexagon hex2 = new Hexagon("Peter");
            //IPointy itfPt2 = hex2 as IPointy;
            //if (itfPt2 != null)
            //    Console.WriteLine("Points: {0}", itfPt2.Points);
            //else
            //    Console.WriteLine("OOPS! Not pointy...");
            //Console.ReadLine();

            Circle c2 = new Circle();
            IPointy iPointyRef = c2 as IPointy;

            if (iPointyRef != null)
            {
                Console.WriteLine($" Circle {c2} implements IPointy Interface.");
            }
            else
            {
                Console.WriteLine($"Circle {c2} doesn't implement IPointy Interface.");
            }

            Console.WriteLine("***** Fun with Interfaces *****\n");
            // Make an array of Shapes.
            Shape[] myShapes = { new Hexagon(), new Circle(),
                new Triangle("Joe"), new Circle("JoJo")};

            for (int i = 0; i < myShapes.Length; i++)
            {
                // Recall the Shape base class defines an abstract Draw()
                // member, so all shapes know how to draw themselves.
                myShapes[i].Draw();

            }
        }
    }
}
