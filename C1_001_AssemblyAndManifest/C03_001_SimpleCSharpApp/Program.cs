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
            // Process any incoming args:
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg: {args[i]}");
            }

            Console.WriteLine("*****My first C# App*****");
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            ShowEnvironmentDetails();

            Console.ReadLine();

            // Wir geben -1 als Errorcode zurück:
            return -1;
        }

        private static void ShowEnvironmentDetails()
        {
            // Print out the drives of this machine,
            // and other interesting details
            foreach (var drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine($"Drive: {drive}");
            }

            Console.WriteLine($"User: {Environment.UserName}");
            Console.WriteLine($"Machine name: {Environment.MachineName}");
            Console.WriteLine($"OS: {Environment.OSVersion}");
            Console.WriteLine($"{Environment.SystemDirectory}");
            Console.WriteLine($"64 bit: {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"Number of processors: {Environment.ProcessorCount}");
            Console.WriteLine($".NET Version: {Environment.Version}");
            Console.WriteLine($"Exit Code: {Environment.ExitCode}");
            Console.WriteLine($"New Line Symbol: {Environment.NewLine}");
            Console.WriteLine($".NET Platform: {Environment.Version}");
            
        }
    }
}
