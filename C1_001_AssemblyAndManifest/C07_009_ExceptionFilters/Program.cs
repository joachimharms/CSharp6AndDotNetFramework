using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_009_ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions with Finally Block and When-Clause *****\n");
            Car myCar = new Car("Rusty", 90);
            myCar.CrankTunes(true);
            try
            {
                // Speed up car logic.
                myCar.Accelerate(50);
            }
            // Mit einer When-Klausel kannst du deine Exceptions wesentlich granularer verwenden:
            catch (CarIsDeadException e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            {
                // This new line will only print if the when clause evaluates to true.
                Console.WriteLine("Catching car is dead! - Catching Clause evaluates to true");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // Process ArgumentOutOfRangeException.
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                // Process any other Exception.
                Console.WriteLine(e.Message);
            }
            finally
            {
                // This will always occur. Exception or not.
                myCar.CrankTunes(false);
            }
            Console.ReadLine();

        }
    }
}
