using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterLibrary
{
    public class PersonFilter
    {
        public IPerson[] FilterByFirstName(IPerson[] PeopleToFilter, string FirstName)
        {
            int validEntries = 0;
            IPerson[] filteredPeopleWithNulls = new IPerson[PeopleToFilter.Length];

            foreach (IPerson currentPerson in PeopleToFilter)
            {
                if (currentPerson != null && currentPerson.FirstName == FirstName)
                {
                    filteredPeopleWithNulls[validEntries] = currentPerson;
                    validEntries++;
                }
            }

            IPerson[] filteredPeople = new IPerson[validEntries];
            for (int i = 0; i < validEntries; i++)
            {
                filteredPeople[i] = filteredPeopleWithNulls[i];
            }

            return filteredPeople;
        }

        public IPerson[] FilterByLastName(IPerson[] PeopleToFilter, string LastName)
        {
            int validEntries = 0;
            IPerson[] filteredPeopleWithNulls = new IPerson[PeopleToFilter.Length];

            foreach (IPerson currentPerson in PeopleToFilter)
            {
                if (currentPerson != null && currentPerson.LastName == LastName)
                {
                    filteredPeopleWithNulls[validEntries] = currentPerson;
                    validEntries++;
                }
            }

            IPerson[] filteredPeople = new IPerson[validEntries];
            for (int i = 0; i < validEntries; i++)
            {
                filteredPeople[i] = filteredPeopleWithNulls[i];
            }

            return filteredPeople;
        }

        public IPerson[] FilterByAge(IPerson[] PeopleToFilter, int Age)
        {
            int validEntries = 0;
            IPerson[] filteredPeopleWithNulls = new IPerson[PeopleToFilter.Length];

            foreach (IPerson currentPerson in PeopleToFilter)
            {
                if (currentPerson != null && currentPerson.Age == Age)
                {
                    filteredPeopleWithNulls[validEntries] = currentPerson;
                    validEntries++;
                }
            }

            IPerson[] filteredPeople = new IPerson[validEntries];
            for (int i = 0; i < validEntries; i++)
            {
                filteredPeople[i] = filteredPeopleWithNulls[i];
            }

            return filteredPeople;
        }
    }
}
