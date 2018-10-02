using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass3
{
    // This is how you inherit from a parent class.
    // ClassName : ParentClassName
    class SalaryEmployee : Employee
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        private decimal weeklySalary;

        //*****************************
        //Properties
        //*****************************
        public decimal Salary
        {
            get
            {
                return weeklySalary * WEEKS_PER_YEAR;
            }
        }

        //******************************
        //Public Methods
        //******************************
        public override string ToString()
        {
            // Must use base to get a reference to the base class.
            // If I did not include it here, it would use the ToString
            // method that I am already in, and start recursion.
            return base.ToString() + " " + Salary.ToString("C");
        }

        //*****************************
        //Constructors
        //*****************************
        public SalaryEmployee(
            string FirstName,
            string LastName,
            decimal WeeklySalary
            // Use the base keyword to delegate the work of setting
            // the first and last name to the parent class by calling
            // the parent (base) constructor.
        ) : base(FirstName, LastName)
        {
            this.weeklySalary = WeeklySalary;
        }
    }
}
