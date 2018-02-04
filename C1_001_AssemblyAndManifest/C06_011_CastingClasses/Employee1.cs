using System;
using System.Globalization;
namespace C06_011_CastingClasses
{

    // Employee.cs - eher häufig zu ändernde Daten
    // Update the Employee class as abstract
    // to prevent direct instantiation.
    public abstract partial class Employee
    {
        #region Methods

        //public void GiveBonus(float amount)
        //{
        //    //this.currPay += amount;
        //    Pay += amount;
        //}

        // This method can now be "overridden" by a derived class.
        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }

        //public void DisplayStats()
        //{
        //    Console.WriteLine("Name: {0}", empName);
        //    Console.WriteLine("ID: {0}", empID);
        //    Console.WriteLine("Pay: {0}", currPay);
        //}

        //// Updated DisplayStats() method now accounts for age.
        //public void DisplayStats()
        //{
        //    Console.WriteLine("Name: {0}", empNam);
        //    Console.WriteLine("ID: {0}", empID);
        //    Console.WriteLine("Age: {0}", empAge);
        //    Console.WriteLine("Pay: {0}", currPay);
        //}

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            //Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
        }
        #endregion

        #region Getter and Setter

        //// Traditional get and set methods:
        //// Accessor (get method).
        //public string GetName()
        //{
        //    return this.empName;
        //}
        //// Mutator (set method).
        //public void SetName(string name)
        //{
        //    // Do a check on incoming value
        //    // before making assignment.
        //    if (name.Length > 15)
        //        Console.WriteLine("Error! Name length exceeds 15 characters!");
        //    else
        //        this.empName = name;
        //}


        // .NET Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    empName = value;
            }
        }

        // The 'int' represents the type of data this property encapsulates.
        // Notice the lack of parantheses
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        #endregion
    }
}