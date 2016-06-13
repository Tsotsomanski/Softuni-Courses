using System;

namespace _4._08_EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            short age = short.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            long personalID = long.Parse(Console.ReadLine());
            int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", LastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalID);
            Console.WriteLine("Unique Employee number: {0}", uniqueEmployeeNumber);
        }
    }
}
