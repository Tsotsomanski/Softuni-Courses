using System;
using System.Collections.Generic;
using _3.CompanyHierarchy.Interfaces;
using _3.CompanyHierarchy;

namespace _3.CompanyHierarchy
{
    class Manager : Employee, IManager
    {
        private List<Employee> employees;

        public Manager(string firstName, string lastName, string id, decimal salary, DepartmentType department, List<Employee> employees)
            : base(firstName, lastName, id, salary, department)
        {
            this.employees = new List<Employee>();
        }

        public IEnumerable<Employee> Employees
        {
            get { return this.employees; }
        }

        public void AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Employee cannot be null !");
            }
            if (employee.Department == this.Department)
            {
                throw new ArgumentException("Department of employee and manager must be the same");
            }
            this.employees.Add(employee);
        }

        public override string ToString()
        {
            string output =
                String.Format("Manager: " + this.FirstName + " " + this.LastName + "\nID: " + this.Id + "\nSalary: " +
                              this.Salary + " BGN" + " \nDepartment: " + this.Department + "\nEmployees: ");
            foreach (var employee in this.Employees)
            {
                output += "\n-" + employee.ToString();
            }
            return output;
        }
    }
}
