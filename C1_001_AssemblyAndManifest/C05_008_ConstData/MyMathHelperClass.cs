using System.Reflection;

namespace C05_008_ConstData
{
    public class MyMathHelperClass
    {
        //public const double Pi = 3.14;


        //// Read-only fields can be assigned in ctors,
        //// but nowhere else.
        //public readonly double Pi;
        //public MyMathHelperClass()
        //{
        //    Pi = 3.14;
        //}

        //// static readonly Field:
        //public static readonly double Pi = 3.14;

        // static readonly Field mit Wertezuweisung über einen statischen Konstruktor
        public static readonly double Pi;
        static MyMathHelperClass()
        { Pi = 3.14; }

    }

}

