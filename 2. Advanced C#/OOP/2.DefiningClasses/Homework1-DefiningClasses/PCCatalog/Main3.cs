using System;
using System.Collections.Generic;

namespace PCCatalog
{
    class Main3
    {
        static void Main()
        {
            List<Computer> computers = AddComputers();
            foreach (var comp in computers)
            {
                Console.WriteLine(comp.ToString());
            }
        }

            public static List<Computer> AddComputers()
        {
            List<Computer> computers = new List<Computer>();
            string ch = null;

            do
            {
                Console.WriteLine("Enter a computer name: ");
                string name = Console.ReadLine();

                List<Components> components = AddComponents();

                Computer computer = new Computer(name, components);
                computers.Add(computer);

                Console.WriteLine("\n Do you want to add a new computer? (y/n) ");
                ch = Console.ReadLine();
            }
            while (ch != "n" && ch != "y");
            return computers;
        }


        static List<Components> AddComponents()
        {
            List<Components> components = new List<Components>();
            string ch = null;

            do
            {
                Console.WriteLine("Enter component name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the component description: ");
                string desc = Console.ReadLine();
                Console.WriteLine("Enter the component price: ");
                double price = double.Parse(Console.ReadLine());
                
                Components component = new Components(name, desc, price);
                components.Add(component);

                Console.WriteLine("\n Do you want to add another component (y\n)? ");
                ch = Console.ReadLine();

            } while (ch != "y" && ch != "n");
            return components;
        }
    }
}