using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass3
{
    class Employee
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        // Make this protected so that child classes
        // have access to it.
        protected const int WEEKS_PER_YEAR = 52;

        private string firstName;
        private string lastName;

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

        //******************************
        //Public Methods
        //******************************
        public string FirstAndLastName()
        {
            return firstName + " " + lastName;
        }

        public override string ToString()
        {
            return FirstAndLastName();
        }

        //*****************************
        //Constructors
        //*****************************
        public Employee(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }

    }
}
