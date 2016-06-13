using System;

namespace Lab2_Capitalism
{
    public class Salesmen : PaidPerson
    {
        public Salesmen(string firstName, string lastName, decimal salary) :
            base(firstName, lastName, salary)
        {
            //1.5% more than the regular salary
        }
    }
}