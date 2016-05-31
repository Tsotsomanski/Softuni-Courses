using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    class AnimalsMain
    {
        public static void Main()
        {
            Cat[] cats = new Cat[] 
            {
                new Cat("Pussi", 3, false),
                new Cat("Pesho", 6, true),
                new Cat("Ginka", 7, false),
            };
            Dog[] dogs = new Dog[] 
            {
                new Dog("Misho", 5, true, "Ovcharka"),
                new Dog("Bull", 6, true, "Buldog"),
                new Dog("Rocko", 7, true, "Sharpei"),
            };
            Frog[] frogs = new Frog[] 
            {
                new Frog("Furi", 2, true),
                new Frog("Mani", 3, false),
                new Frog("Perr", 2, false),
            };
            Kitten[] kittens = new Kitten[] 
            {
                new Kitten("Stupi", 1, "Persian"),
                new Kitten("Lili", 1, "Persian"),
                new Kitten("Plupi", 2, "Angora"),
            };
            Tomcat[] tomcats = new Tomcat[] 
            {
                new Tomcat("Gunko", 4),
                new Tomcat("Porfavor", 3),
                new Tomcat("Kalin", 5),
            };

            double dogsAvAge = Animal.AverageAge(dogs);
            double catsAvAge = Animal.AverageAge(cats);
            double frogsAvAge = Animal.AverageAge(frogs);
            double kittensAvAge = Animal.AverageAge(kittens);
            double tomcatsAvAge = Animal.AverageAge(tomcats);

            Console.WriteLine("Average age: \nDogs: {0:F1};\nCats: {1:F1};\nFrogs: {2:F1};\nKittens: {3:F1};\nTomcats: {4:F1};", 
                dogsAvAge, catsAvAge, frogsAvAge, kittensAvAge, tomcatsAvAge);
            Console.WriteLine();

            Console.WriteLine("Different animals sounds:");
            Console.Write("Cats: ");
            cats[0].ProduceSound();
            Console.Write("Dogs: ");
            dogs[1].ProduceSound();
            Console.Write("Frogs: ");
            frogs[2].ProduceSound();
            Console.WriteLine();

            Console.WriteLine("Different animals character activities:");
            Console.WriteLine(dogs[2].SpinTail());
            Console.WriteLine(cats[1].Tease());
            Console.WriteLine(frogs[2].Jump());
        }
    }
}
