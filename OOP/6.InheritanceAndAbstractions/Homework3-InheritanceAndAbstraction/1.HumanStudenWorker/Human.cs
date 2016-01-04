using System;

namespace Homework3_InheritanceAndAbstraction
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }


        public override string ToString()
        {
            return String.Format
                ("First name: " + this.FirstName + 
                " Last name: " + this.LastName);
        }
    }
}
