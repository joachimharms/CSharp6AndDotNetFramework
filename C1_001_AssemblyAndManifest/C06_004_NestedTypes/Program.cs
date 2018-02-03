using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_004_NestedTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and use the public inner class. OK!
            OuterClass.PublicInnerClass inner;
            inner = new OuterClass.PublicInnerClass();
            // Compiler Error! Cannot access the private class.
            //OuterClass.PrivateInnerClass inner2;
            //inner2 = new OuterClass.PrivateInnerClass();

            // Aufruf einer tief nested Enumeration BenefitPackageLevel
            // Define my benefit level.
            Employee.BenefitPackage.BenefitPackageLevel myBenefitLevel =
            Employee.BenefitPackage.BenefitPackageLevel.Platinum;
            Console.ReadLine();
        }
    }
}
