using System;
using _3.CompanyHierarchy.Interfaces;

namespace _3.CompanyHierarchy
{
    public abstract class Person : IPerson
    {
        private string firstName;
        private string lastName;
        private string id;

        public Person (string firstName, string lastName, string id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                { 
                    throw new ArgumentNullException(value, "First name cannot be empty !");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                { 
                    throw new ArgumentNullException(value, "The last name cannot be empty !");
                }
                this.lastName = value;
            }
        }
        public string Id
        {
            get {return this.id; }
            set
            {
                if (value.Length < 5)
                { 
                    throw new ArgumentException("ID cannot contain less than 5 letters !");
                }
                this.id = value;
            }
        }

        //public override string ToString()
        //{
        //    return String.Format("First name: " + this.FirstName + " Last name: " + this.LastName + " ID: " + this.Id);
        //}
    }
}
