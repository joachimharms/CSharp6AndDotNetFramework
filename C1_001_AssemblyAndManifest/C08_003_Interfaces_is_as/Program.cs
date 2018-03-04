using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_003_Interfaces_is_as
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces - as keyword *****\n");
            // Can we treat hex2 as IPointy?
            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;
            if (itfPt2 != null)
                Console.WriteLine("Points: {0}", itfPt2.Points);
            else
                Console.WriteLine("OOPS! Not pointy...");
            Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("***** Fun with Interfaces - is keyword *****\n");
            // Make an array of Shapes.
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };

            for (int i = 0; i < myShapes.Length; i++)
            {
                // Recall the Shape base class defines an abstract Draw()
                // member, so all shapes know how to draw themselves.
                myShapes[i].Draw();

                // Who's pointy?
                if (myShapes[i] is IPointy)
                    Console.WriteLine("-> Points: {0}", ((IPointy)myShapes[i]).Points);
                else
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);
                Console.WriteLine();

                Console.ReadLine();
            }

        }
    }
}
