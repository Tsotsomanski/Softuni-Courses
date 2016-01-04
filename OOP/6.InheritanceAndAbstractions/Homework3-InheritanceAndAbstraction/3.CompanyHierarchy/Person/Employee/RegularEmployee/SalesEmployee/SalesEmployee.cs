using System;
using System.Collections.Generic;

namespace _3.CompanyHierarchy
{
    class SalesEmployee : RegularEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(string firstName, string lastName, string id, decimal salary, DepartmentType department, List<Sale> sales)
            : base(firstName, lastName, id, salary, department)
        {
            this.sales = new List<Sale>();
        }


        // This is IEnumerable (not List) because in this way we are encapsulating our program and nobady can edit our list !
        public IEnumerable<Sale> Sales
        {
            get { return this.sales; }
        }


        public void AddSales(Sale sale)
        {
            if (sale == null)
            {
                throw  new ArgumentNullException(sale.ToString(), "Sale cannot be empty !");
            }
            this.sales.Add(sale);
        }

        public override string ToString()
        {
            string output = String.Format("Sales employee: " + this.FirstName + " " + this.LastName + "\nID: " + 
                this.Id + "\nSalary: " + this.Salary + " BGN" + "\nDepartment type: " + this.Department + "\nSales");
            foreach (var sale in this.Sales)
            {
                output += sale.ToString();
            }
            return output;
        }
    }
}
