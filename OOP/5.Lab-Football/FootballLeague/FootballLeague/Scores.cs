using System;

namespace FootballLeague
{
    class Scores
    {
        private int homeTeamGoals;
        private int awayTeamGoals;


        public Scores(int homeTeamGoals, int awayTeamGoals)
        {
            this.AwayTeamGoals = awayTeamGoals;
            this.HomeTeamGoals = homeTeamGoals;
        }
        public int HomeTeamGoals
        {
            get
            {
                return this.HomeTeamGoals;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("The number of goals can't be negative number !");
                this.homeTeamGoals = value;
            }
        }
        public int AwayTeamGoals
        {
            get
            {
                return this.AwayTeamGoals;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("The number of goals can't be negative number !");
                this.homeTeamGoals = value;
            }
        }

        
        public override string ToString() 
        { 
             return string.Format("{0} - {1}", this.homeTeamGoals, this.awayTeamGoals); 
        } 
    }
}
