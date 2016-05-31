namespace FootballLeague
{
    using System;

    class Players
    {
        private const int minimumAllowedYear = 1980;
        private string firstName;
        private string lastName;
        private DateTime dateOfBird;
        private decimal salary;
        private Team team;

        public Players(string firstName, string lastName, DateTime dateOfBird, decimal salary, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBird = dateOfBird;
            this.Salary = salary;
            this.Team = team;
        }

        public string FirstName
        {
            get
            {
                return this.FirstName;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 3)
                    throw new ArgumentException("The first name should be longer than 3 characters !");
                this.FirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.LastName;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length < 3)
                    throw new ArgumentException("The last name should be longer than 3 characters !");
                this.LastName = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return this.Salary;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Salary can't be negative number !");
                this.Salary = value;
            }
        }
        public DateTime DateOfBird
        {
            get
            {
                return this.DateOfBird;
            }
            set
            {
                if (value.Year < minimumAllowedYear)
                    throw new ArgumentException("Year cannot be before 1980 !");
                this.dateOfBird = value;
            }
        }

        public Team Team { get; set; }

        public override string ToString()
        {
            return "Name: " + this.firstName + " " + this.lastName + ", Salary: " + this.salary + ", Date of Birth: " + 
                    this.DateOfBird.ToShortDateString() + ", Team: " + team.Name; 
        }

    }
}
