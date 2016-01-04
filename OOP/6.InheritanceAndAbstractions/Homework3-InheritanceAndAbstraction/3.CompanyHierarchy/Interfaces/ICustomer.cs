using System;

namespace _3.CompanyHierarchy.Interfaces
{
    interface ICustomer : IPerson
    {
        decimal NetPurchaseAmount { get; set; }
    }
}
