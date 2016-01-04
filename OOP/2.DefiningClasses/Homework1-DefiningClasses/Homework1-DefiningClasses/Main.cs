using System;

namespace Homework1_DefiningClasses
{
    class Main
    {
        static void Main()
        {
            Person sasho = new Person("Sasho", 18);
            Person gosho = new Person("Gosho", 20, "gosh@abv.bg");
            Person pesho = new Person("Pesho", 0);
            Person misho = new Person("", 1);
            Person dinko = new Person("Dinko", 20, "gosh abv.bg");

            Console.WriteLine(gosho);

        }
    }
}
