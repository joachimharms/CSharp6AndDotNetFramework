using System;

namespace C1_001_AssemblyAndManifest
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Calculator();
            int ans = c.Add(12, 7);

            Console.WriteLine(ans);
        }
    }
}
