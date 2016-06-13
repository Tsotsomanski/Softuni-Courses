using System;
using System.Collections.Generic;
using System.Linq;

public class FootbalLeague
{
    public static void Main()
    {
        string key = Console.ReadLine();
        string matchInfo = "";
        Dictionary<string, int> teamsAndGoals = new Dictionary<string, int>();

        while (matchInfo != "final")
        {
            matchInfo = Console.ReadLine();

            if (matchInfo == "final")
            {
                break;
            }

            List<int> indexes = new List<int>();
            int index = matchInfo.IndexOf(key);

            while (index != -1)
            {
                indexes.Add(index);
                index = matchInfo.IndexOf(key, index + 1);
            }

            //Team A name - Take and reverse
            int startIndexA = indexes[0] + key.Length;
            string teamAName = matchInfo.Substring(startIndexA, (indexes[1] - startIndexA));
            string reversedNameA = "";
            for (int i = teamAName.Length - 1; i >= 0; i--)
            {
                reversedNameA += teamAName[i];
            }
            string offNameA = reversedNameA.ToLower();
            
            //Team B name - Take and reverse
            int startIndexB = indexes[2] + key.Length;
            string teamBName = matchInfo.Substring(startIndexB, (indexes[3] - startIndexB));
            string reversedNameB = "";
            for (int i = teamBName.Length - 1; i >= 0; i--)
            {
                reversedNameB += teamBName[i];
            }
            string offNameB = reversedNameB.ToLower();

            // Parsing the goals
            int goalsIndex = matchInfo.IndexOf(":");
            int teamAgoals = int.Parse(Convert.ToString(matchInfo[goalsIndex - 1]));
            int teamBgoals = int.Parse(Convert.ToString(matchInfo[goalsIndex + 1]));

            if (!teamsAndGoals.ContainsKey(offNameA))
            {
                teamsAndGoals.Add(offNameA, teamAgoals);
            }
            else if (!teamsAndGoals.ContainsKey(offNameB))
            {
                teamsAndGoals.Add(offNameB, teamBgoals);
            }
            else if(teamsAndGoals.ContainsKey(offNameA))
            {
                teamsAndGoals[offNameA] += teamAgoals;
            }
            else if(teamsAndGoals.ContainsKey(offNameB))
            {
                teamsAndGoals[offNameB] += teamBgoals;
            }
        }

        foreach (var team in teamsAndGoals)
        {
            Console.WriteLine(team);
        }
    }
}












































//List<string> splitedInfo = matchInfo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
//string teamA = "";

//for (int i = 0; i < splitedInfo.Count; i++)
//{
//    int startIndex = splitedInfo[i].IndexOf(key) + key.Length;
//    int endIndex = splitedInfo[i].LastIndexOf(key);
//    int length = (splitedInfo[i].Length - startIndex) - (splitedInfo[i].Length - endIndex - 1);
//    teamA = splitedInfo[i].Substring(startIndex, length);

//}