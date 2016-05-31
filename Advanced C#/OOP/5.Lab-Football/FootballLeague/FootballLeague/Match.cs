namespace FootballLeague
{
    using System;

    class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Scores score;
        private int id;
        
        public Match(Team homeTeam, Team awayTeam, Scores score, int id)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.score = score;
            this.Id = id;
        }


        public Team HomeTeam 
        {
            get
            { return this.homeTeam; }
            set 
            {
                if (value.Equals(this.awayTeam))
                    throw new ArgumentException("The team cannot be the same as the Away team.");
                this.homeTeam = value;
            }
        }

        public Team AwayTeam 
        {
            get
            {
                return this.awayTeam;
            }
            set 
            { 
                if (value.Equals(this.homeTeam))
                    throw new ArgumentException("The team cannot be the same as the Home team.");
                this.awayTeam = value;
            }
        }


        public Team Score { get; set; }

        public int Id
        {
            get
            {
                return this.Id;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("The score cannot be lower than 0 !");
                this.Id = value;
            }
        }

    }
}
