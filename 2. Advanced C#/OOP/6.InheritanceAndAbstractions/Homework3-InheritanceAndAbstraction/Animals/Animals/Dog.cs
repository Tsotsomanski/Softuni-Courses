using System;

namespace Animals
{
    class Dog : Animal
    {
        private string breed;

        public Dog(string name, int age, bool isMale, string breed) 
            : base(name, age, isMale)
        {
            this.Breed = breed;
        }

        public string Breed {get; set;}

        public string SpinTail()
        {
            return string.Format("{0} is rotating it's tail !", this.Name);
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bau bauUu");
        }
    }
}
