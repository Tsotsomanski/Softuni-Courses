using System;

namespace _3._04_Elevator
{
    class Program
    {
        static void Main()
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double numOfCourses = 0;

            if (numOfPeople < capacity)
            {
                numOfCourses = 1;
                Console.WriteLine(numOfCourses);
            }
            else
            {
                if (numOfPeople / capacity != 0)
                {
                    numOfCourses = (int)Math.Ceiling((double)numOfPeople / capacity);
                    Console.WriteLine(numOfCourses);
                }
                else
                {
                    numOfCourses = numOfPeople / capacity;

                    Console.WriteLine(numOfCourses);
                }
            }
        }
    }
}
