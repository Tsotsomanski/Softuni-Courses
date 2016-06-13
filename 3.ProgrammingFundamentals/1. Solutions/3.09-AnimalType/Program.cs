using System;

namespace _3._09_AnimalType
{
    class Program
    {
        static void Main()
        {
            string[] animalTypes = { "mammal", "reptile", "unknown"};
            string input = Console.ReadLine();

            switch (input)
            {
                case "dog":
                    Console.WriteLine(animalTypes[0]);
                    break;
                case "tortoise":
                    Console.WriteLine(animalTypes[1]);
                    break;
                case "crocodile":
                    Console.WriteLine(animalTypes[1]);
                    break;
                case "snake":
                    Console.WriteLine(animalTypes[1]);
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
