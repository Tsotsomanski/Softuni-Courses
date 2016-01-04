using System;
using System.Text;

namespace Homework3_InheritanceAndAbstraction
{
    class Worcker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;

        public Worcker(double weekSalary, int workHoursPerDay, string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }


        public double WeekSalary
        {
            get { return this.weekSalary; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative number !");
                this.weekSalary = value; 
            }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Work hours per day cannot be negative number !");
                this.workHoursPerDay = value;
            }
        }


        public double GetMoneyPerHour()
        {
            double moneyPerHour = 0;
            moneyPerHour = (this.WeekSalary / 5) / this.WorkHoursPerDay;
            return Math.Round(moneyPerHour, 2);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Name: " + this.FirstName + this.LastName + " earns -> {0} BGN per hour", this.GetMoneyPerHour()));
            return result.ToString();
        }
    }
}
