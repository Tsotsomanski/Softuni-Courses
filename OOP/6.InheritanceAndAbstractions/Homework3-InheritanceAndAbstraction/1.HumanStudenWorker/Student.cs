using System;
using System.Linq;

namespace Homework3_InheritanceAndAbstraction
{
    class Student : Human
    {
        private string facultyNum;

        public Student(string firstName, string lastName, string facultyNum)
            : base(firstName, lastName)
        {
            this.FacultyNum = facultyNum;
        }


        public string FacultyNum
        {
            get { return this.facultyNum; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                    throw new ArgumentException("The facultu number must be between 5 and 10 digits !");
                this.facultyNum = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: " + this.FirstName + 
                this.LastName + "-> Faculty number: " +
                this.FacultyNum);
        }
    }
}
