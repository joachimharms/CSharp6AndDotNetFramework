using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_005_PolymorphicSupport
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }


        // expliziter default Konstruktor:
        public SalesPerson() { }

        // As a general rule, all subclasses should explicitly call an appropriate
        // base class constructor.
        public SalesPerson(string fullName, int age, int empID,
        float currPay, string ssn, int numbOfSales)
        : base(fullName, age, empID, currPay, ssn)
        {
            // This belongs with us!
            SalesNumber = numbOfSales;
        }

    }
}
