﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C006_003_ProtectedKeyword
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string fullName, int age, int empID,
        float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empID, currPay, ssn, numbOfSales)
        {

        }
        // Assume other members here...
    }
}