using System;
using Lab2_Capitalism.Models;

namespace Lab2_Capitalism
{
    public class Manager : PaidPerson, IBoss
    {
        public Manager(string firstName, string lastName, decimal salary) :
            base(firstName, lastName, salary)
        {

        }
    }
}