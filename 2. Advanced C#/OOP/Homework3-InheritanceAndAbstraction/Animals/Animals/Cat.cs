using System;

namespace Animals
{
    class Cat : Animal
    {
        public Cat(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
            //
        }

        public string Tease()
        {
            return string.Format("{0} is teasing !", this.Name);
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MiaowWw miaowWwwwww"); ;
        }

    }
}
