using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Football_League
{

    public class FootballLeague
    {
        public static void Main()
        {
            string key = Regex.Escape(Console.ReadLine());

            string pattern = $@"^.*(?:{key})(?<team1>[a-zA-Z]*)(?:{key}).* .*(?:{key})(?<team2>[a-zA-Z]*)(?:{key}).* (?<team1Score>\d+):(?<team2Score>\d+).*$";

            Dictionary<string, Score> teamScores = new Dictionary<string, Score>();

            string line = Console.ReadLine();
            while(line != "final")
            {
                Match match = Regex.Match(line, pattern);

                if (!match.Success)
                {
                    line = Console.ReadLine();
                    continue;
                }

                string team1Name = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                string team2Name = new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                int team1Goals = int.Parse(match.Groups["team1Score"].Value);
                int team2Goals = int.Parse(match.Groups["team2Score"].Value);

                if (!teamScores.ContainsKey(team1Name))
                {
                    teamScores[team1Name] = new Score();
                }

                if (!teamScores.ContainsKey(team2Name))
                {
                    teamScores[team2Name] = new Score();
                }

                if (team1Goals > team2Goals)
                {
                    teamScores[team1Name].Points += 3;
                }
                else if (team1Goals == team2Goals)
                {
                    teamScores[team1Name].Points++;
                    teamScores[team2Name].Points++;
                }
                else
                {
                    teamScores[team2Name].Points += 3;
                }

                teamScores[team1Name].Goals += team1Goals;
                teamScores[team2Name].Goals += team2Goals;

                line = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            int place = 1;

            IOrderedEnumerable<KeyValuePair<string, Score>> leagueStandings = teamScores
                .OrderByDescending(a => a.Value.Points)
                .ThenBy(a => a.Key);

            foreach (var leagueStanding in leagueStandings)
            {
                string teamName = leagueStanding.Key;
                decimal teamPoints = leagueStanding.Value.Points;

                Console.WriteLine($"{place++}. {teamName} {teamPoints}");
            }

            Console.WriteLine("Top 3 scored goals:");

            IEnumerable<KeyValuePair<string, Score>> top3Goals = teamScores
                .OrderByDescending(a => a.Value.Goals)
                .ThenBy(a => a.Key)
                .Take(3);

            foreach (var teamGoals in top3Goals)
            {
                string teamName = teamGoals.Key;
                decimal goals = teamGoals.Value.Goals;

                Console.WriteLine($"- {teamName} -> {goals}");
            }
        }
    }
}
