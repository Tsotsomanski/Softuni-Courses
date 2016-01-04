using System;
using System.Collections.Generic;
using Lab2_Capitalism.Models;

namespace Lab2_Capitalism
{
    public class Company : ICompanyStruct
    {
        public string Name { get; set; }

        public  CEO CEO { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}
