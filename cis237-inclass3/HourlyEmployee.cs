using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass3
{
    class HourlyEmployee
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        const int WEEKS_PER_YEAR = 52;

        private string firstName;
        private string lastName;
        private decimal hourlyRate;
        private decimal hoursPerWeek;

        //*****************************
        //Properties
        //*****************************
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public decimal Salary
        {
            get
            {
                return this.hourlyRate * this.hoursPerWeek * WEEKS_PER_YEAR;
            }
        }

        //******************************
        //Public Methods
        //******************************
        public string FirstAndLastName()
        {
            return firstName + " " + lastName;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + Salary.ToString("C");
        }

        //*****************************
        //Constructors
        //*****************************
        public HourlyEmployee(
            string FirstName,
            string LastName,
            decimal HourlyRate,
            decimal HoursPerWeek
        ) {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.hourlyRate = HourlyRate;
            this.hoursPerWeek = HoursPerWeek;
        }
    }
}
