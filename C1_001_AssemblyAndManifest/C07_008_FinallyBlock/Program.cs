using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_008_FinallyBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions with Finally Block *****\n");
            Car myCar = new Car("Rusty", 90);
            myCar.CrankTunes(true);
            try
            {
                // Speed up car logic.
                myCar.Accelerate(-10);
            }
            catch (CarIsDeadException e)
            {
                // Process CarIsDeadException.
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
