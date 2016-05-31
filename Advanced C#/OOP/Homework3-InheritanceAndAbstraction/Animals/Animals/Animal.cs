using System;
using Contracts;
using System.Linq;

namespace Animals
{
    abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private bool isMale;

        public Animal(string name, int age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.isMale = isMale;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("The name cannot be empty!");
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age cannot be negative number!");
                this.age = value;
            }
        }
        public bool IsMale
        {
            get { return this.isMale; }
            set { this.isMale = value; }
        }

        public string Hunt()
        {
            return string.Format("{0} is hunting !", this.Name);
        }

        public abstract void ProduceSound();



        public static double AverageAge(Animal[] animalsArr)
        {
            return animalsArr.Average(x => x.Age);
        }
    }
}
