using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FilterLibrary;

namespace cis237_inclass3
{
    interface IEmployee : IPerson
    {
        // An interface contains only method declarations and
        // properties. There is no need to put an access modifier down
        // because it will always be public. We are specifying only public
        // methods and properties.

        // Any class that implements this interface MUST implement the following:
        // Methods
        string FormattedSalary();

        string FirstAndLastName();

        // Properties
        new string FirstName
        {
            get;
            set;
        }
        new string LastName
        {
            get;
            set;     
        }
        decimal Salary
        {
            get;
        }
    }
}
