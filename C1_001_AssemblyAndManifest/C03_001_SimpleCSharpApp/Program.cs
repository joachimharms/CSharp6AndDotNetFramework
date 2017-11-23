using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_001_SimpleCSharpApp
{
    class Program
    {
        // Wir ändern den Rückgabewert einer Main-Methode von void nach int: 
        static int Main(string[] args)
        {
            Console.WriteLine("*****My first C# App*****");
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            Console.ReadLine();

            // Wir geben -1 als Errorcode zurück:
            return -1;
        }
    }
}
