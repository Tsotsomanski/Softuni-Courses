using System;
using Lab2_Capitalism.Models;

namespace Lab2_Capitalism
{
    public abstract class PaidPerson : IPaidPerson
    {
        private string firstName;
        private string lastName;
        private decimal salary;

        public PaidPerson(string firstName, string lastName, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public void PaySalary()
        {
            //
        }
    }
}