using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_013_IsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // A Manager "is-a" System.Object, so we can
            // store a Manager reference in an object variable just fine.
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);

            // A Manager "is-an" Employee too.
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);

            // A PTSalesPerson "is-a" SalesPerson.
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
            GivePromotion(jill);


            //object frank2 = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            //// Error!
            //GivePromotion(frank2);

            //// OK! Explizites Downcasting von System.Object in Manager:
            //GivePromotion((Manager)frank);

            GivePromotion((Manager)frank);
        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("-------------- Typenkompatibilitätsprüfung mit is keyword: ---------------");
            Console.WriteLine("{0} was promoted!", emp.Name);
            if (emp is SalesPerson)
            {
                Console.WriteLine("{0} made {1} sale(s)!", emp.Name,
                ((SalesPerson)emp).SalesNumber);
                Console.WriteLine();
            }
            if (emp is Manager)
            {
                Console.WriteLine("{0} had {1} stock options...", emp.Name,
                ((Manager)emp).StockOptions);
                Console.WriteLine();
            }
        }
    }


}
