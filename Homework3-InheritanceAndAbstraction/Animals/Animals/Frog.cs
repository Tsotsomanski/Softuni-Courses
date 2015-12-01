﻿using System;

namespace Animals
{
    class Frog : Animal
    {
        public Frog (string name, int age, bool isMale)
            : base(name, age, isMale)
        {
            //
        }

        public string Jump()
        {
            return string.Format("{0} is jumping around !", this.Name);
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Croak croakk");
        }

    }
}
