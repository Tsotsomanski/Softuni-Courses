using System;

namespace Lab2_Capitalism.Models
{
    interface IEmployee : IPaidPerson
    {
        Department Department { get; }

        double SalaryFactor { get; }
    }
}
