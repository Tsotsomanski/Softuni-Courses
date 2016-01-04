using System;

namespace Lab2_Capitalism.Models
{
    public class Employee : PaidPerson
    {
        public Department Department { get; set; }

        protected double SalaryFactor { get; set; }

        public Employee(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
        }
    }
}
