using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duncan_courseproject_part2
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string ssn;
        private DateTime hireDate;

        // Constructors

        // Behaviors

        // Properties
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length > 0)
                {
                    firstName = value;
                }
                else
                {
                    firstName = "unknown";
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length > 0)
                {
                    lastName = value;
                }
                else
                {
                    lastName = "unknown";
                }
            }
        }

    }
}
