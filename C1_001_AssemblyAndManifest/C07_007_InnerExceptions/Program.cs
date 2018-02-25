using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C07_007_InnerExceptions
{
    class Program
    {

            static void Main(string[] args)
            {
            //Console.WriteLine("***** Handling Inner Exceptions *****\n");
            //Car myCar = new Car("Rusty", 90);
            //try
            //{
            //    // Trip exception.
            //    myCar.Accelerate(50);
            //}
            //catch (CarIsDeadException e)
            //{
            //// Attempt to open a file named carErrors.txt on the C drive.
            //FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
            //}
            //catch (Exception e2)
            //{
            //    // Throw an exception that records the new exception
            //    // as well as the message of the first exception.
            //    throw new CarIsDeadException(e.Message, e2);
            //}

            Console.WriteLine("****** Handling Inner Exceptions *******\n");
            Car myCar = new Car("Rusty", 90);

            try
            {
                // Trip excetpion
                myCar.Accelerate(50);
            }
            catch (CarIsDeadException e)
            {

                try
                {
                    // Attempt to open a file named carErrors.txt on the C drive.
                    FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
                }
                catch (Exception e2)
                {
                    // Throw an exception that records the new exception
                    // as well as the message of the first exception.
                    throw new CarIsDeadException(e.Message, e2);
                }
            }
        }

    }
}
