using System;

namespace _3.CompanyHierarchy.Interfaces
{
    interface IEmployee : IPerson
    {
        decimal Salary { get; set; }
    }
}
