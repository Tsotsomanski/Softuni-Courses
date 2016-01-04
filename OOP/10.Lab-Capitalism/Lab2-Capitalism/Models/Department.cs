using System;
using System.Collections.Generic;
using Lab2_Capitalism.Models;

namespace Lab2_Capitalism
{
    public class Department : ICompanyStruct
    {
        public Department()
        {
            this.Employees = new List<IEmployee>();
        }

        public string Name { get; set; }

        public Manager Manager { get; set; }

        private ICollection<IEmployee> Employees { get; set; }
    }
}
