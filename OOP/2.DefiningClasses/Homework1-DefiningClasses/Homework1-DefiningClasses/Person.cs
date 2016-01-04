using System;
namespace Homework1_DefiningClasses
{
    class Person
    {
        public string name;
        public int age;
        public string email;

        public Person(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }

        public Person(string name, int age) : this(name, age, "") {   }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be empty!");
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("The age can not be lower than 1 and greater than 100");
                    this.age = value;
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (String.IsNullOrEmpty(email))
                {
                    this.email = "there is no email";
                }
                else if (!email.Contains("@"))
                {
                    throw new ArgumentException("The email have to contain @");
                }
                else this.email = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Email: {2}", this.name, this.age, this.email);
        }
    }
}
