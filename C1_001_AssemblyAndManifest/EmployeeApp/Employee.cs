using System;
using System.Globalization;

namespace EmployeeApp
{
    public class Employee
    {
        #region Field Data

        private string empName;

        private int empID;

        private float currPay;

        #endregion

        #region Getter and Setter

        // Accessor (get method).
        public string GetName()
        {
            return this.empName;
        }
        // Mutator (set method).
        public void SetName(string name)
        {
            // Do a check on incoming value
            // before making assignment.
            if (name.Length > 15)
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            else
                this.empName = name;
        }

        #endregion

        #region Constructors

        public Employee()
        {

        }

        public Employee(string name, int id, float pay)
        {
            this.empName = name;
            this.empID = id;
            this.currPay = pay;
        }
        #endregion

        #region Methods

        public void GiveBonus(float amount)
        {
            this.currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
        }
        #endregion
    }
}