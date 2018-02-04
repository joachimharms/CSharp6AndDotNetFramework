﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_013_IsKeyword
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

        // A salesperson's bonus is influenced by the number of sales.
        // SalesPerson has sealed the GiveBonus() method!
        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }
    }
}
