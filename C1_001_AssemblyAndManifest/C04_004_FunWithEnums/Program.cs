using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_004_FunWithEnums
{
    //// A custom enumeration.
    //enum EmpType
    //{
    //    Manager, // = 0
    //    Grunt, // = 1
    //    Contractor, // = 2
    //    VicePresident // = 3
    //}

    //// Begin with 102.
    //enum EmpType
    //{
    //    Manager = 102,
    //    Grunt, // = 103
    //    Contractor, // = 104
    //    VicePresident // = 105
    //}

    //// Elements of an enumeration need not be sequential!
    //enum EmpType
    //{
    //    Manager = 10,
    //    Grunt = 1,
    //    Contractor = 100,
    //    VicePresident = 9
    //}

    // This time, EmpType maps to an underlying byte.
    enum EmpType : byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VicePresident = 9
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Enums *****");
            // Make an EmpType variable.
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("**** Fun with underlying Types of Enums*****");
            // Make a contractor type.
            EmpType emp2 = EmpType.Contractor;
            AskForBonus(emp2);
            // Print storage for the enum.
            Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(emp2.GetType()));
            Console.ReadLine();
            Console.WriteLine();

            // This time use typeof to extract a Type.
            Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(typeof(EmpType)));
            Console.WriteLine();

            Console.WriteLine("**** Fun with ToString Method *****");
            EmpType emp3 = EmpType.Contractor;
            AskForBonus(emp3);
            // Prints out "emp is a Contractor".
            Console.WriteLine("emp3 is a {0}.", emp3.ToString());
            Console.ReadLine();

            Console.WriteLine("**** Fun mit Enum Werte - Konsolenausgabe *****");
            EmpType emp4 = EmpType.Contractor;
            // Prints out "Contractor = 100".
            Console.WriteLine("{0} = {1}", emp4.ToString(), (byte)emp4);
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("**** Fun with Enums *****");
            EmpType e2 = EmpType.Contractor;
            // These types are enums in the System namespace.
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);
            Console.ReadLine();
        }


        // Enums as parameters.
        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }

        // This method will print out the details of any enum.
        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}",
                Enum.GetUnderlyingType(e.GetType()));
            // Get all name/value pairs for incoming parameter.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);
            // Now show the string name and associated value, using the D format
            // flag (see Chapter 3).
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}",
                    enumData.GetValue(i));
            }
            Console.WriteLine();
        }
    }
}

