using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C06_011_ClassCastings
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string fullName, int age, int empID,
        float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empID, currPay, ssn, numbOfSales)
        {

        }

        //// Compiler error! Can't override this method
        //// in the PTSalesPerson class, as it was sealed.
        //public override void GiveBonus(float amount)
        //{
        //}
        
        // Assume other members here...
    }
}