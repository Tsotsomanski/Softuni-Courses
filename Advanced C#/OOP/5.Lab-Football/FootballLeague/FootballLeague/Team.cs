namespace FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Team
    {
        private string name;
        private string nickName;
        private DateTime dateOfFounding;
        private List<Players> players;


        public Team(string name, string nickName, DateTime dateOfFounding)
        {
            this.Name = name;
            this.NickName = nickName;
            this.dateOfFounding = dateOfFounding;
            this.players = new List<Players>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (name.Length < 5)
                {
                    throw new ArgumentException("The name must be at least 5 symbols! ");
                }
                this.Name = value;
            }
        }
        public string NickName
        {
            get
            {
                return this.nickName;
            }
            set
            {
                if (nickName.Length < 5)
                {
                    throw new ArgumentException("The nickname must be at least 5 symbols! ");
                }
                this.NickName = value;
            }
        }
        public DateTime DateOfFounding
        {
            get
            {
                return this.dateOfFounding;
            }
            set
            {
                if (value.Year < 1980)
                {
                    throw new ArgumentOutOfRangeException("The date must be after 1980 year !");
                }

                this.DateOfFounding = value;
            }
        }
        public IEnumerable<Players> Players
        {
            get
            {
                return this.players;
            }
        }
        public void AddPlayer(Players player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("The player already exists.");
            }

            else
	        {
                this.players.Add(player);
	        }
        }

        public bool CheckIfPlayerExists(Players player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName && p.LastName == p.LastName);
        }

        public override string ToString()
        {
            return this.name + "(" + this.nickName + ") - " + "Founded: " + this.dateOfFounding.ToShortDateString()
                + "\nPlayers:\n" + String.Join("\n", this.players);
        }

    }
}
