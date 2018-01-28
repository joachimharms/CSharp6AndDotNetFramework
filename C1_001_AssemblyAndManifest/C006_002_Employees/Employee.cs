using System;
using System.Globalization;

namespace C006_002_Employees
{
    // Employee.Core.cs - eher selten zu ändernde Daten
    public partial class Employee
    {
        #region Field Data

        private string empName;

        private int empID;

        private float currPay;

        // New field and property.
        private int empAge;
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        #endregion



        #region Constructors

        //public Employee()
        //{

        //}

        //public Employee(string name, int id, float pay)
        //{
        //    this.empName = name;
        //    this.empID = id;
        //    this.currPay = pay;
        //}

        // Updated constructors.
        public Employee() { }

        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay) { }

        public Employee(string name, int age, int id, float pay)
        {
            ////empName = name;
            //// Humm, this seems like a problem...
            //if (name.Length > 15)
            //    Console.WriteLine("Error! Name length exceeds 15 characters!");
            //else
            //    empName = name;

            // Better! Use properties when setting class data.
            // This reduces the amount of duplicate error checks.
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;

            //empID = id;
            //empAge = age;
            //currPay = pay;
        }
        #endregion


    }
}