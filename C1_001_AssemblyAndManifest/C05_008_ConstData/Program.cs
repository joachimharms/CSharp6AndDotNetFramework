using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05_008_ConstData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Const *****\n");
            //Console.WriteLine("The value of PI is: {0}", MyMathHelperClass.Pi);
            // Error! Can't change a constant!
            // MyMathClass.PI = 3.1444;
            Console.ReadLine();


            //Console.WriteLine("Readonly Data:");
            //MyMathHelperClass mathHelper = new MyMathHelperClass();
            //Console.WriteLine("The value of PI is: {0}", mathHelper.Pi);
            //Console.ReadLine();

            Console.WriteLine("static Readonly Data mit Werte Zuweisung zur Laufzeit über einen statischen Konstruktor: ");
            MyMathHelperClass mathHelper = new MyMathHelperClass();
            Console.WriteLine("The value of PI is: {0}", MyMathHelperClass.Pi);
        }
    }
}
