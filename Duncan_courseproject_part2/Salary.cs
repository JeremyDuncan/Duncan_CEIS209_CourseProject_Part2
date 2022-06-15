using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duncan_courseproject_part2
{
    internal class Salary : Employee
    {
        // attributes
        private double annualSalary;


        // constructors
        public Salary() : base()
        {
            annualSalary = 0.0; 
        }

        public Salary(string firstName, string lastName, string ssn,
            DateTime hireDate, Benefits benefits, double annualSalary) 
            : base(firstName, lastName, ssn, hireDate, benefits)
        {
            AnnualSalary = annualSalary;
        }

        // behaviors 
        public override string ToString()
        {
            return base.ToString() + ", Salary: " + annualSalary.ToString("C");
        }

        // properties
        public double AnnualSalary
        {
            get
            {
                return annualSalary;
            }
            set
            {
                if (value > 0.0 && value < 1000000.0)
                    annualSalary = value;
                else
                    annualSalary = 0.0;
            }
        }   
    }
}
