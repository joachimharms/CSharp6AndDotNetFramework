using System;

// Import the static members of Console and DateTime.
using static System.Console;
using static System.DateTime;


namespace C05_003_StaticDataAndMembers
{
    // Static classes can only
    // contain static members!
    public static class TimeUtilClass
    {
        //public static void PrintTime()
        //{ Console.WriteLine(DateTime.Now.ToShortTimeString()); }
        //public static void PrintDate()
        //{ Console.WriteLine(DateTime.Today.ToShortDateString()); }

        public static void PrintTime()
        { WriteLine(Now.ToShortTimeString()); }
        public static void PrintDate()
        { WriteLine(Today.ToShortDateString()); }
    }
}