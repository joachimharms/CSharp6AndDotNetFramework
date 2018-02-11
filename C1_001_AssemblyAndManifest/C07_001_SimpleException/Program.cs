using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_001_SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** Simple Exception Example *****");
            //Console.WriteLine("=> Creating a car and stepping on it!");
            //Car myCar = new Car("Zippy", 20);
            //myCar.CrankTunes(true);
            //for (int i = 0; i < 10; i++)
            //    myCar.Accelerate(10);
            //Console.ReadLine();

            // Handle the thrown exception.
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            // Speed up past the car's max speed to
            // trigger the exception.
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine($"Method: {e.TargetSite}");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Source: {e.Source}");
            }

            // The error has been handled, processing continues with the next statement.
            Console.WriteLine("\n***** Out of exception logic *****");
            Console.ReadLine();

        }
    }
}
