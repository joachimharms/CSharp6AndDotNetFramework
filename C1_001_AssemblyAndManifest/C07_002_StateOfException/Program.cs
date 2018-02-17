using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C07_002_StateOfException
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



            // Configure the State of an Exception - page 256
            //Console.WriteLine("***** Simple Exception Example *****");
            //Console.WriteLine("=> Creating a car and stepping on it!");
            //Car myCar = new Car("Zippy", 20);
            //myCar.CrankTunes(true);
            //for (int i = 0; i < 10; i++)
            //    myCar.Accelerate(10);
            //Console.ReadLine();

            // Handle the thrown exception.
            Console.WriteLine("***** Simple Exception Example 2 *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar2 = new Car("Tanja", 20);
            myCar2.CrankTunes(true);

            // Speed up past the car's max speed to
            // trigger the exception.
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar2.Accelerate(10);
                }
            }
            // TargetSite actually returns a MethodBase object.
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine("Member name: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}",
                e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);

                // StackTraceProperty dokumentiert Aufrufhierarchie und genaue Lokalisierung des beleidigten Members, der die Exception geschmissen hat.
                Console.WriteLine("Stack: {0}", e.StackTrace);

                // HelpLink Property Wert der Klasse Exception in der Klasse Car gesetzt und im CatchBlock ausgegeben.
                Console.WriteLine("Help Link: {0}", e.HelpLink);

                Console.WriteLine();
                // DataProperty um das Exception Objekt mit weiteren Informationen anzufüllen:
                Console.WriteLine("\n-> Custom Data:");
                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine("-> {0}: {1}", de.Key, de.Value);

                // (JH) Nächstes Kapitel
                Console.WriteLine();
                Console.WriteLine("Prüfe ob es sich bei der Car Exception um eine System.ApplicationException handelt: ");
                Console.WriteLine("Exception e is-a ApplicationException? : {0}", e is ApplicationException);
            }

            // The error has been handled, processing continues with the next statement.
            Console.WriteLine("\n***** Out of exception logic *****");
            Console.ReadLine();


            Console.WriteLine("Prüfe ob eine NullReferenceException Objekt vom Ty SystemException ist:" );
            // True! NullReferenceException is-a SystemException.
            NullReferenceException nullRefEx = new NullReferenceException();
            Console.WriteLine("NullReferenceException is-a SystemException? : {0}",
            nullRefEx is SystemException);



        }
    }
}
