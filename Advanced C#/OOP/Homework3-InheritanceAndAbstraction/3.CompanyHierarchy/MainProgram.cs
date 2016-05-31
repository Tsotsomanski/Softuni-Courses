using System;
using System.Collections.Generic;

namespace _3.CompanyHierarchy
{
    class MainProgram
    {
        static void Main()
        {
            Manager mainManager = new Manager("First", "Manager", "01asdf", 1350m, DepartmentType.Accounting,
                new List<Employee>
                {
                    new SalesEmployee("First", "Employee", "ewgfwae", 900m, DepartmentType.Sales, new List<Sale>
                    {
                        new Sale("Some product", DateTime.Now, 140m),
                        new Sale("Some other product", DateTime.Parse("February 26, 2009"), 199.99m)
                    }),

                    new Developer("First", "Developer", "01dbz5", 1000m, DepartmentType.Production, new List<Project>
                    {
                        new Project("Some project", DateTime.Parse("06.09.1999"), "random details about the project", true),
                        new Project("Cataloon",DateTime.Parse("08.05.2005"), "The project is fine !", true)
                    })
                });
            Console.WriteLine(mainManager);



            Customer cust = new Customer("Kiro", "Kirov", "1264gf3", 515);
            Manager theManager = new Manager("Georgi", "Petrov", "98126i82s", 6000, DepartmentType.Marketing,new List<Employee>()
            {
                new Developer("Aleksandar", "Valentinov", "S775HCs", 2200, DepartmentType.Production,new List<Project>()
                {
                    new Project("SoftUniGame", DateTime.Today, "The project is not ready, but we are working on it", true),
                    new Project("UNSS", DateTime.UtcNow, "details", true)
                })
            });

            
            Console.WriteLine();
            Console.WriteLine(theManager);

        }
    }
}