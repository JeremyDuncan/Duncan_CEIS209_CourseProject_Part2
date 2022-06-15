using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duncan_courseproject_part2
{
    internal class Hourly : Employee
    {
        // attributes
        private float  hourlyRate;
        private float hoursWorked;


        // constructors
        public Hourly() : base()
        {
            hourlyRate = 0.0f;
            hoursWorked = 0.0f;
        }
        public Hourly(string firstName, string lastName, string ssn,
            DateTime hireDate, Benefits benefits, float hourlyRate, float hoursWorked)
            : base(firstName, lastName, ssn, hireDate, benefits)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        // behaviors 
        public override string ToString()
        {
            return base.ToString() + ", Hourly Rate: " + hourlyRate.ToString("C")
            + ", Hours Worked: " + hoursWorked.ToString();
        }

        // properties
        public float HourlyRate
        {
            get
            {
                return hourlyRate; 
            }
            set
            {
                if (value > 0.0f && value < 1000.0f)
                    hourlyRate = value;
                else
                    hourlyRate = 0.0f;
            }
        }

        public float HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                if (value > 0.0f && value < 160.0f)
                    hoursWorked = value;
                else
                    hoursWorked = 0.0f;
            }
        }
    }
}
 