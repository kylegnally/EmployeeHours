﻿using System;
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
        private string firstName;
        private string lastName;
        private decimal weeklySalary;

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

        public decimal WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
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
            return firstName + " " + lastName + " " + weeklySalary.ToString("C");
        }

        //*****************************
        //Constructors
        //*****************************
        public Employee(string FirstName, string LastName, decimal WeeklySalary)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.weeklySalary = WeeklySalary;
        }

        public Employee()
        {
            //Do Nothing
        }
    }
}
