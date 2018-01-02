using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05_002_ConstructorChainingThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with class Types *****\n");
            // Make a Motorcycle.
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.driverName);
            Console.ReadLine();

            Motorcycle.MakeSomeBikes();
        }
    }
}
