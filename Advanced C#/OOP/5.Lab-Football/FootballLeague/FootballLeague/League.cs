using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballLeague
{
    static class League
    {
        private static List<Team> teams = new List<Team>();
        private static List<Match> matches = new List<Match>();

        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }
        public static IEnumerable<Match> Matches
        {
            get { return matches; }
        }

        
        public static void AddMatches(Match match)
        {
            if (AddMatchesChecker(match))
            {
                throw new InvalidOperationException("Match already exists in the league.");
            }
            matches.Add(match);
        }
        public static bool AddMatchesChecker(Match match)
        {
            return Matches.Any(m => m.Id == match.Id);
        }

        public static void AddTeams(Team team)
        {
            if (AddTeamsChecker(team))
            {
                throw new InvalidOperationException("Team already exists in the league.");
            }
            teams.Add(team);
        }
        public static bool AddTeamsChecker(Team team)
        {
            return Teams.Any(t => t.Name == team.Name);
        }
    }
}
