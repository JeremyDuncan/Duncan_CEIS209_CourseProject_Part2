using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duncan_courseproject_part2
{
    internal class Benefits
    {
        private string healthIns;
        private double lifeIns;
        private int vacation;

        // Constructors
        public Benefits()
        {
            healthIns = "unknown";
            lifeIns = 0.0;
            vacation = 0;
        }
        public Benefits(string healthIns, double lifeIns, int vacation)
        {
            this.HealthIns = healthIns;
            this.LifeIns = lifeIns;
            this.Vacation = vacation;
        }
        // Behaviors
        public override string ToString()
        {
            return
                "Health Insurance:" + healthIns + ", " +
                "Life Insurance: " + lifeIns + ", " +
                "Vacation: " + vacation + " days";
        }
        // Properties
        public string HealthIns
        {
            get { return healthIns; }
            set { healthIns = ((value.Length > 0) ? value : "unknown"); }
        }
        public double LifeIns
        {
            get { return lifeIns; }
            set { lifeIns = ((value > 0.0 && value <= 10000000) ? value : 0.0); }
        }
        public int Vacation
        {
            get { return vacation; }
            set { vacation = ((value > 0) ? value : 0); }
        }
    }
}
