using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Lab2_Capitalism.Models
{
    public interface IBoss
    {
        ICollection<Employee> SubordinateEmployees { get; set; }
    }
}
