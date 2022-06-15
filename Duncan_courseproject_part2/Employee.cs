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
        private Benefits benefits;

        // Constructors
        public Employee()
        {
            firstName = "unknown";
            lastName = "unknown";
            ssn = "unknown";
            hireDate = DateTime.MinValue;

        }
        public Employee( string firstName, string lastName, string ssn, DateTime hireDate, Benefits benefits)
        {
            this.FirstName = firstName; 
            this.LastName = lastName;
            this.SSN = ssn; 
            this.HireDate = hireDate;
            BenefitsPackage = benefits;
            
        }
        // Behaviors
        public override string ToString()
        {
            return 
                firstName + " " + lastName + ", " +
                "SSN: " + ssn + ", " +
                "Hire Date: " + hireDate.ToShortDateString(); 
        }

        public virtual double CalculatePay()
        {
            return 0.0;
        }

        // Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = ((value.Length > 0) ? value : "unknown"); }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = ((value.Length > 0) ? value : "unknown"); }
        }
        public string SSN
        {
            get { return ssn; }
            set { ssn = ((value.Length > 0) ? value : "unknown"); }
        }
        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = ((value.Year >= 1950 && value.Year <= DateTime.Now.Year + 1) ? value : DateTime.MinValue); }
        }

        public Benefits BenefitsPackage
        {
            get { return benefits; }
            set { this.benefits = value; }
        }
    }
}
