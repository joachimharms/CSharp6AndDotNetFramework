using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_006_ArrayOfInterfaceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This array can only contain types that
            // implement the IPointy interface.
            IPointy[] myPointyObjects = {new Hexagon(), new Knife(), new Triangle(), new Fork(), new PitchFork()};
            foreach (IPointy i in myPointyObjects)
                Console.WriteLine("Object has {0} points.", i.Points);
            Console.ReadLine();
        }
    }
}
