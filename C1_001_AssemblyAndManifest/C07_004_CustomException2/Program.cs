using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_004_CustomException2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);
            try
            {
                // Trip exception.
                myCar.Accelerate(50);
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ErrorTimeStamp);
                Console.WriteLine(e.CauseOfError);
            }
            Console.ReadLine();

            //// Verwendung des Codesnippets exception TAB TAB -> erstellt eine Custom Exception Klasse, die den best Practices für eine Exception Klasse entspricht!
            //    [Serializable]
            //public class MyException : Exception
            //{
            //    public MyException() { }
            //    public MyException(string message) : base(message) { }
            //    public MyException(string message, Exception inner) : base(message, inner) { }
            //    protected MyException(
            //      System.Runtime.Serialization.SerializationInfo info,
            //      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
            //}
        }
    }
}
