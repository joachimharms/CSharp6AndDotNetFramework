using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C06_011_ClassCasting
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
            : base(fullName, age, empID, currPay, ssn)
        {
            StockOptions = numbOfOpts;
        }

        // Add back the default ctor
        // in the Manager class as well.
        public Manager() { }

        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
        }


    }
}
