using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cis237_inclass3
{
    // This is an abstract class. It is made abstract by adding the 'abstract'
    // keyword before the word class. Abstract classes can NOT be instaciated.
    // The primary use for them is to provide functionality that child classes
    // can use, and extend from.
    public abstract class Employee : IEmployee
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

        public abstract decimal Salary { get; }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //******************************
        //Public Methods
        //******************************
        // An abstract method MUST have no method body. Hence the ; at the end.
        // An abstract method MUST be overridden in all child classes.
        // You can only put abstract methods in an abstrat class.
        // We made this method abstract because based on the information that
        // this class has, we have no idea how to calculate a salary, let alone
        // format one.
        // Declaring it abstract leaves the implementation details to the child
        // class to figure out.
        public abstract string FormattedSalary();

        // A virtual method MUST have a method body, even if it is empty
        // A virtual method CAN be overridden in child classes, but not required.
        // A virtual method can exist in abstact and non-abstract classes.
        // We made this method virtual because we already have all of the
        // needed information to provide a method body. We simply left it
        // virtual i case a subclass would like to override it for some reason.
        public virtual string FirstAndLastName()
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
