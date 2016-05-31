using System;
using _3.CompanyHierarchy.Interfaces;
using _3.CompanyHierarchy;

namespace _3.CompanyHierarchy
{
    class RegularEmployee : Employee
    {
        public RegularEmployee(string firstName, string lastName, string id, decimal salary, DepartmentType department)
            : base(firstName, lastName, id, salary, department)
        {
            //
        }
    }
}
