using System;

namespace Lab2_Capitalism
{
    public class RegularEmployee : PaidPerson
    {
        public RegularEmployee(string firstName, string lastName, decimal salary) :
            base(firstName, lastName, salary)
        {
            
        }
    }
}