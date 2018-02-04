using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_012_AsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Ack! You can't cast frank to a Hexagon, but this compiles fine!
            //object frank = new Manager();
            //Hexagon hex = (Hexagon)frank;

            // Catch a possible invalid cast.
            object frank = new Manager();
            Hexagon hex;
            try
            {
                hex = (Hexagon)frank;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Use "as" to test compatability.
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thing";
            foreach (object item in things)
            {
                Hexagon h = item as Hexagon;
                if (h == null)
                    Console.WriteLine("Item is not a hexagon");
                else
                {
                    h.Draw();
                }
            }
        }
    }
}
