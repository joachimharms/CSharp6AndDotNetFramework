using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05_001_SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");
            // Allocate and configure a Car object.
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;
            // Speed up the car a few times and print out the
            // new state.
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Aufruf eines überschriebenen Default Konstruktors, \nder die Felder des Objektes mit Werten (Chuck und 10) instanziiert");
            // Invoking the default constructor.
            Car chuck = new Car();
            // Prints "Chuck is going 10 MPH."
            chuck.PrintState();

            Console.WriteLine();
            Console.WriteLine("Aufruf der überladenen Konstruktoren");
            // Make a Car called Mary going 0 MPH.
            Car mary = new Car("Mary");
            mary.PrintState();
            // Make a Car called Daisy going 75 MPH.
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();
            Console.WriteLine();

            Console.WriteLine("***** Fun with Motorcycles *****\n");
            Motorcycle mc = new Motorcycle();
            mc.PopAWheely();

            var mc2 = new Motorcycle(5);
            mc2.PopAWheely();
            Console.WriteLine();

            // Make a Motorcycle with a rider named Tiny?
            Console.WriteLine("Mehrdeutigkeit bei Übergabe der Argumente der Methode \naufgrund fehlendes this in der Methodendeklaration");
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.name); // Prints an empty name value!
        }
    }
}
