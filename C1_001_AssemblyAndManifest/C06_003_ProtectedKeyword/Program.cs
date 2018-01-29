using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C006_003_ProtectedKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a subclass object and access base class functionality.
                Console.WriteLine("***** The Employee Class Hierarchy *****\n");
                SalesPerson fred = new SalesPerson();
                fred.Age = 31;
                fred.Name = "Fred";
                fred.SalesNumber = 50;
                Console.ReadLine();

        }
    }

}
