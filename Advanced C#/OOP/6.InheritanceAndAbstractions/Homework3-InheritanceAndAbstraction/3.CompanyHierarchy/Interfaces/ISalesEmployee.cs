﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompanyHierarchy.Interfaces
{
    interface ISalesEmployee : IRegularEmployee
    {
        IEnumerable<Sale> Sales { get; set; }
    }
}