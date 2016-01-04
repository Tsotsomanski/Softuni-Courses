using System;
using System.Collections.Generic;

namespace _3.CompanyHierarchy.Interfaces
{
    interface IDeveloper : IRegularEmployee
    {
        List<Project> Projects { get; set; }
    }
}
