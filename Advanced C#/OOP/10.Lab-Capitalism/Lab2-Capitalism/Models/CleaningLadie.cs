using System;

namespace Lab2_Capitalism
{
    public class CleaningLadie : PaidPerson
    {
        public CleaningLadie(string firstName, string lastName, decimal salary) :
            base(firstName, lastName, salary)
        {
            //2% less than the regular salary 
        }
    }
}