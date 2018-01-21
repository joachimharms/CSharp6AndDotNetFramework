using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C005_005_AutomaticPropertiesAndDefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage g = new Garage();
            // 0OK, prints default value of zero.
            Console.WriteLine($"Numbers of cars in Garage: {g.NumberOfCars}");

            //// Runtime error! - NullReference Exception - Backing field is currently null!
            //Console.WriteLine($"Name of car: {g.MyCar.PetName}");





            Car c1 = new Car();
            c1.PetName = "Rudi Auto";
            c1.Color = "Pink";
            c1.Speed = 100;



            Console.WriteLine("Wir instanziieren eine Garage und fügen ihr ein Autoobjekt hinzu: ");
            // Put car in the garage.
            Garage2 g2 = new Garage2();
            g2.MyCar = c1;
            Console.WriteLine($"Numbers of cars in Garage: {g2.NumberOfCars}");
            Console.WriteLine($"Name of car {g2.MyCar.PetName}");
        }
    }
}
