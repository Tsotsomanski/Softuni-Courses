using System;

namespace Lab2_Capitalism
{
    public class ChiefTelephoneOfficer : PaidPerson
    {
        public ChiefTelephoneOfficer(string firstName, string lastName, decimal salary) :
            base(firstName, lastName, salary)
        {
            //2% less than the regular salary 
        }
    }
}