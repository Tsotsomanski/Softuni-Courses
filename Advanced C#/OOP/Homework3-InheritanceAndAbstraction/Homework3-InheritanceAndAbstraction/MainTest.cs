using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3_InheritanceAndAbstraction
{
    class MainTest
    {
        static void Main()
        {
            var students = InitializeStudents();
            var sortedStudents = SortStudentsByFacultyNum(students);
            Console.WriteLine("Here are the students sorted by their faculty number: ");
            Console.WriteLine();
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0,-9} {1,-14} fac.N. -> {2}", student.FirstName, student.LastName, student.FacultyNum);
            }
            Console.WriteLine();
            Console.WriteLine();

            var workers = InitializeWorkers();
            var sortedWorkers = SortWorkersByMPHDescending(workers);
            Console.WriteLine("These are the workers sorted by descending by their money per hour.");
            Console.WriteLine();
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("{0,-9} {1,-12} -> {2:C} per hour.", worker.FirstName, worker.LastName, worker.GetMoneyPerHour());
            }
            Console.WriteLine();
            Console.WriteLine();

            var mergedGroups = sortedStudents
                    .Concat<Human>(sortedWorkers)
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.LastName);
            Console.WriteLine("These are sorted groups by First name and after that by Last name. ");
            Console.WriteLine();
            foreach (var human in mergedGroups)
            {
                Console.WriteLine("Name: {0,-10} {1}", human.FirstName, human.LastName);
            }
        }



        private static List<Student> SortStudentsByFacultyNum(IEnumerable<Student> students)
        {
            var result = students.OrderBy(s => s.FacultyNum)
                                 .ToList();
            return result;
        }
        public static List<Student> InitializeStudents()
        {
            List<Student> students = new List<Student>();
            
            students.Add(new Student("Stefcho ", "Aarabadjiev ", "125050"));
            students.Add(new Student("Milen ", "Kovachki ", "125254"));
            students.Add(new Student("Georgi ", "Sotirov ", "125170"));
            students.Add(new Student("Atanas ", "Aleksandrov ", "125058"));
            students.Add(new Student("Petq ", "Milanova ", "125157"));
            students.Add(new Student("Petar ", "Stoinev ", "125171"));
            students.Add(new Student("Hristo ", "Velinov ", "125260"));
            students.Add(new Student("Velizar ", "Grigorov ", "125280"));
            students.Add(new Student("Nikol ", "Petrova ", "125150"));
            students.Add(new Student("Silviq ", "Manolova ", "125238"));

            return students;
        }

        private static List<Worcker> SortWorkersByMPHDescending(IEnumerable<Worcker> workers)
        {
            var result = workers.OrderByDescending(x => x.GetMoneyPerHour())
                                   .ToList();
            return result;
        }
        public static List<Worcker> InitializeWorkers()
        {
            List<Worcker> workers = new List<Worcker>();

            workers.Add(new Worcker(150, 8, "Mihail ", "Ardenski "));
            workers.Add(new Worcker(180, 8, "Kosa ", "Brailob "));
            workers.Add(new Worcker(100, 5, "Georgi ", "Malinov "));
            workers.Add(new Worcker(80, 4, "Boris ", "Aleksandrov "));
            workers.Add(new Worcker(150, 6, "Penka ", "Milanova "));
            workers.Add(new Worcker(200, 10, "Emil ", "Stoinev "));
            workers.Add(new Worcker(230, 12, "Biser ", "Velinov "));
            workers.Add(new Worcker(155, 7, "Velizara ", "Grigorova "));
            workers.Add(new Worcker(140, 8, "Nikolai ", "Prodanov "));
            workers.Add(new Worcker(130, 7, "Biser ", "Borisov "));

            return workers;
        }
    }
}
