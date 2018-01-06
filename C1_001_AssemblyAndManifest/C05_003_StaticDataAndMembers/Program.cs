using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05_003_StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {

            ////// Compiler error! WriteLine() is not an object level method!
            ////Console c = new Console();
            ////c.WriteLine("I can't be printed...");

            //// Correct! WriteLine() is a static method.
            //Console.WriteLine("Much better! Thanks...");
            //Console.WriteLine();

            //Console.WriteLine("***** Fun with Static Data *****");
            //Console.WriteLine("***Shared static data:***\n");
            //SavingsAccount s1 = new SavingsAccount(50);
            //SavingsAccount s2 = new SavingsAccount(100);
            //Console.ReadLine();

            //// Print the current interest rate.
            //Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            //// Make new object, this does NOT 'reset' the interest rate.
            //SavingsAccount s3 = new SavingsAccount(10000.75);
            //Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            //Console.ReadLine();

            Console.WriteLine("***** Fun with Static Data *****");
            Console.WriteLine("Statische Werte werden jedesmal zurückgesetzt bei Instanziierung eines neuen Objektes (durch falsche Konstruktorenlogik):\n");
            // Make an account.
            SavingsAccount s1 = new SavingsAccount(50);
            // Print the current interest rate.
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            // Try to change the interest rate via property.
            SavingsAccount.SetInterestRate(0.08);
            // Make a second account.
            SavingsAccount s2 = new SavingsAccount(100);
            // Should print 0.08...right??
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("***** Fun with static classes *****");
            // This is just fine.
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

            //// Compiler error! Can't create instance of static classes!
            //TimeUtilClass u = new TimeUtilClass();

            Console.ReadLine();


        }
    }
}
