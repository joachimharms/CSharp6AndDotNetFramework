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

            // Hier prüfst mittel explizitem Casting in das Interface und mithilfe von Structured Exceptionhandling, 
            // ob der Typ das Interface implementiert hat.
            // Catch a possible InvalidCastException.
            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
