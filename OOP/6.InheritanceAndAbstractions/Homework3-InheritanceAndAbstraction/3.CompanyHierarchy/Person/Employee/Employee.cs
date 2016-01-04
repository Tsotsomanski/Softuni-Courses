using System;
using _3.CompanyHierarchy.Interfaces;
using _3.CompanyHierarchy;

namespace _3.CompanyHierarchy
{
    abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private DepartmentType department;

        protected Employee(string firstName, string lastName, string id, decimal salary, DepartmentType department)
            : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.department = department;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be smaller than 0 !");
                }
                this.salary = value;
            }
        }
        public DepartmentType Department { get; set; }
    }
}
