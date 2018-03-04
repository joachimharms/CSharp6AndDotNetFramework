using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_005_InterfacesAsReturnValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces - Interfaces as return values *****\n");
            // Make an array of Shapes.
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo")};
            // Get first pointy item.
            // To be safe, you'd want to check firstPointyItem for null before proceeding.
            IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            Console.WriteLine("The item has {0} points", firstPointyItem.Points);
        }

        // This method returns the first object in the
        // array that implements IPointy.
        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy)
                    return s as IPointy;
            }
            return null;
        }
    }
}
