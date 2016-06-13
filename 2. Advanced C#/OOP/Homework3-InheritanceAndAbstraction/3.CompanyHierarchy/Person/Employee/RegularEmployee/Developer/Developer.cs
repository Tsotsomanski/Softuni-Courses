using System;
using System.Collections.Generic;
using _3.CompanyHierarchy.Interfaces;

namespace _3.CompanyHierarchy
{
    class Developer : RegularEmployee, IDeveloper
    {
        private List<Project> projects;

        public Developer(string firstName, string lastName, string id, decimal salary, DepartmentType department, List<Project> projects)
            : base(firstName, lastName, id, salary, department)
        {
            this.projects = new List<Project>();
        }

        public List<Project> Projects { get; set; }

        public override string ToString()
        {
            string output =
                String.Format("Developer: " + this.FirstName + " " + this.LastName + "\nID: " + this.Id + "\nSalary: " +
                              this.Salary + " BGN" +
                              "\nDepartment type: " + this.Department + "Projects: ");
            foreach (var project in Projects)
            {
                output += "\n" + project.ToString();
            }
            return output;
        }
    }
}