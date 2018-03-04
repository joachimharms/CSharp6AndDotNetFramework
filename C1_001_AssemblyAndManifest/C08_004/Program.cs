using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces and Interfaces as Parameters *****\n");
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };
            for (int i = 0; i < myShapes.Length; i++)
            {
                // Can I draw you in 3D?
                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);
            }

        }

        // I'll draw anyone supporting IDraw3D.
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }


    }
}
