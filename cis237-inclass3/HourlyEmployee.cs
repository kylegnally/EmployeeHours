using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass3
{
    public class HourlyEmployee : Employee
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        private decimal hourlyRate;
        private decimal hoursPerWeek;

        //*****************************
        //Properties
        //*****************************
        public override decimal Salary
        {
            get
            {
                return this.hourlyRate * this.hoursPerWeek * WEEKS_PER_YEAR;
            }
        }

        //******************************
        //Public Methods
        //******************************
        public override string ToString()
        {
            return base.ToString() + " " + Salary.ToString("C");
        }

        // Overriding the abstract method in Employee
        public override string FormattedSalary()
        {
            return Salary.ToString("C");
        }

        // Did not override the virtual method in Employee FirstAndLastName

        //*****************************
        //Constructors
        //*****************************
        public HourlyEmployee(
            string FirstName,
            string LastName,
            decimal HourlyRate,
            decimal HoursPerWeek
        ) : base(FirstName, LastName)
        {
            this.hourlyRate = HourlyRate;
            this.hoursPerWeek = HoursPerWeek;
        }
    }
}
