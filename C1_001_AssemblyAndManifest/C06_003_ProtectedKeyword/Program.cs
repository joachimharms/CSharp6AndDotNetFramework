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

                Console.WriteLine("Containment - Komposition - Delegate exposiert die Funktionalität von BenefitPackage durch die beinhaltende Employee Klasse");
                Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
                double cost = chucky.GetBenefitCost();
                Console.ReadLine();

        }
    }

}
