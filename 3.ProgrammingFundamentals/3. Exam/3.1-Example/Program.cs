using System;
using System.Collections.Generic;
using System.Linq;

class FootballStandings
{
    static void Main()
    {
        string key = Console.ReadLine();
        string[] encryptedLine = Console.ReadLine().Split(' ');
        bool isThisTheEnd = encryptedLine[0].ToLower() == "final";
        string[] encryptedLineTeamNames = new string[2];
        int[] encryptedMatchScore = new int[2];
        Dictionary<string, int> leagueStanding = new Dictionary<string, int>();
        Dictionary<string, int> topScorer = new Dictionary<string, int>();
        char[] keyLength = key.ToCharArray();


        while (isThisTheEnd == false)
        {
            Dictionary<string, int> matchScore = new Dictionary<string, int>();
            encryptedMatchScore = encryptedLine[2].Split(':').Select(int.Parse).ToArray();

            for (int i = 0; i < 2; i++)
            {
                int firstStartPosition = 0;
                int position = encryptedLine[i].IndexOf(key, firstStartPosition);
                firstStartPosition = position;
                int nextStartPosition = firstStartPosition + 1;

                position = encryptedLine[i].IndexOf(key, nextStartPosition);
                int endtPosition = position;

                string teamName = encryptedLine[i].Substring(firstStartPosition + keyLength.Length, endtPosition - (firstStartPosition + keyLength.Length));
                char[] teamNamesReverse = teamName.ToCharArray().Reverse().ToArray();
                encryptedLineTeamNames[i] = string.Join("", teamNamesReverse).ToUpper();

                matchScore.Add(encryptedLineTeamNames[i], encryptedMatchScore[i]);

                if (topScorer.ContainsKey(encryptedLineTeamNames[i]))
                {
                    topScorer[encryptedLineTeamNames[i]] += matchScore[encryptedLineTeamNames[i]];
                }
                else
                {
                    topScorer.Add(encryptedLineTeamNames[i], encryptedMatchScore[i]);
                }

                if (i == 1)
                {
                    if (matchScore[encryptedLineTeamNames[0]] > matchScore[encryptedLineTeamNames[1]])
                    {
                        if (leagueStanding.ContainsKey(encryptedLineTeamNames[0]))
                        {
                            leagueStanding[encryptedLineTeamNames[0]] += 3;
                        }
                        else
                        {
                            leagueStanding.Add(encryptedLineTeamNames[0], 3);
                        }

                        if (leagueStanding.ContainsKey(encryptedLineTeamNames[1]))
                        {
                            leagueStanding[encryptedLineTeamNames[1]] += 0;
                        }
                        else
                        {
                            leagueStanding.Add(encryptedLineTeamNames[1], 0);
                        }
                    }
                    else if (matchScore[encryptedLineTeamNames[0]] == matchScore[encryptedLineTeamNames[1]])
                    {
                        if (leagueStanding.ContainsKey(encryptedLineTeamNames[0]))
                        {
                            leagueStanding[encryptedLineTeamNames[0]] += 1;
                        }
                        else
                        {
                            leagueStanding.Add(encryptedLineTeamNames[0], 1);
                        }

                        if (leagueStanding.ContainsKey(encryptedLineTeamNames[1]))
                        {
                            leagueStanding[encryptedLineTeamNames[1]] += 1;
                        }
                        else
                        {
                            leagueStanding.Add(encryptedLineTeamNames[1], 1);
                        }
                    }
                    else if (matchScore[encryptedLineTeamNames[0]] < matchScore[encryptedLineTeamNames[1]])
                    {
                        if (leagueStanding.ContainsKey(encryptedLineTeamNames[1]))
                        {
                            leagueStanding[encryptedLineTeamNames[1]] += 3;
                        }
                        else
                        {
                            leagueStanding.Add(encryptedLineTeamNames[1], 3);
                        }

                        if (leagueStanding.ContainsKey(encryptedLineTeamNames[0]))
                        {
                            leagueStanding[encryptedLineTeamNames[0]] += 0;
                        }
                        else
                        {
                            leagueStanding.Add(encryptedLineTeamNames[0], 0);
                        }
                    }
                }
            }
            matchScore.Clear();
            encryptedLine = Console.ReadLine().Split(' ');
            isThisTheEnd = encryptedLine[0].ToLower() == "final";
        }

        Console.WriteLine("League standings:");

        var myList = leagueStanding.ToList();
        myList.Sort((pair2, pair1) => pair1.Value.CompareTo(pair2.Value));

        int counter = 1;
        foreach (var team in myList)
        {
            Console.Write("{0}. ", counter);
            Console.WriteLine(team.Key + " " + team.Value);
            counter += 1;
        }


        var myList2 = topScorer.ToList();
        myList2.Sort((pair2, pair1) => pair1.Value.CompareTo(pair2.Value));

        Console.WriteLine("Top 3 scored goals:");
        foreach (var team in myList2.Take(3))
        {
            Console.Write(" - ");
            Console.WriteLine("{0} -> {1}", team.Key, team.Value);
        }
    }
}