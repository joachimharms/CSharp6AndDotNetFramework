using System;
using System.Globalization;

namespace C006_003_ProtectedKeyword
{
    // Employee.Core.cs - eher selten zu ändernde Daten
    public partial class Employee
    {
        #region Field Data

        //private string empName;

        //private int empID;

        //private float currPay;

        //private string empSSN;

        // Derived classes can now directly access this information.
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;

        // New field and property.
        public int Age
        {
            get { return this.empAge; }
            set { this.empAge = value; }
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


        // Add to the Employee class.
        public Employee(string name, int age, int id, float pay, string ssn)
            :this(name, age, id, pay)
        {
            empSSN = ssn;
        }
        #endregion


    }
}