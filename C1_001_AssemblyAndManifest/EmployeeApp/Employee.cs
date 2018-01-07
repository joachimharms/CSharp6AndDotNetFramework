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

        // New field and property.
        private int empAge;
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
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

        #region Methods

        public void GiveBonus(float amount)
        {
            //this.currPay += amount;
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

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
        }
        #endregion
    }
}