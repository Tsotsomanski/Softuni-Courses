using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Capitalism.Models
{
    interface IPaidPerson : IPerson
    {
        decimal Salary { get; set; }
    }
}
