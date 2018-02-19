using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_006_ProcessMultipleExceptions
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("***** Handling Multiple Exceptions *****\n");
        //    Car myCar = new Car("Rusty", 90);
        //    try
        //    {
        //        // Trip Arg out of range exception.
        //        myCar.Accelerate(-10);
        //    }
        //    catch (CarIsDeadException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    catch (ArgumentOutOfRangeException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    Console.ReadLine();
        //}

        //// This code will not compile! Dieser Code kompiliert nicht aufgrund der falschen Anordnung der Catch-Blöcke. Der erste allgemeinste Block muss nach hinten, ansonsten werden
        //// die beiden folgenden catch-Blöcke unnereichbar.
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("***** Handling Multiple Exceptions *****\n");
        //    Car myCar = new Car("Rusty", 90);
        //    try
        //    {
        //        // Trigger an argument out of range exception.
        //        myCar.Accelerate(-10);
        //    }
        //    catch (Exception e)
        //    {
        //        // Process all other exceptions?
        //        Console.WriteLine(e.Message);
        //    }
        //    catch (CarIsDeadException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    catch (ArgumentOutOfRangeException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    Console.ReadLine();
        //}

        //// This code compiles just fine. // Hier wurde die Anordnung der Catch-Blöcke richtig gemacht.
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("***** Handling Multiple Exceptions *****\n");
        //    Car myCar = new Car("Rusty", 90);
        //    try
        //    {
        //        // Trigger an argument out of range exception.
        //        myCar.Accelerate(-10);
        //    }
        //    catch (CarIsDeadException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    catch (ArgumentOutOfRangeException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    // This will catch any other exception
        //    // beyond CarIsDeadException or
        //    // ArgumentOutOfRangeException.
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    Console.ReadLine();
        //}

        //// A generic catch.
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("***** Handling Multiple Exceptions *****\n");
        //    Car myCar = new Car("Rusty", 90);
        //    try
        //    {
        //        myCar.Accelerate(90);
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Something bad happened...");
        //    }
        //    Console.ReadLine();
        //}

        // Passing the buck.
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);
            try
            {
                // Trip exception.
                myCar.Accelerate(50);
            }
            catch (CarIsDeadException e)
            {
                // Do any partial processing of this error and pass the buck.
                throw;
            }
}
    }
}
