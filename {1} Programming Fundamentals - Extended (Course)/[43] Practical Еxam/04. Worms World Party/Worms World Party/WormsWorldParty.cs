using System;
using System.Collections.Generic;
using System.Linq;

namespace Worms_World_Party
{
    public class Worm
    {
        public string Name { get; set; }

        public string TeamName { get; set; }

        public long Score { get; set; }
    }

    public class WormsWorldParty
    {
        public static void Main()
        {
            Dictionary<string, List<Worm>> wormsDict = new Dictionary<string, List<Worm>>();
            List<string> wormNames = new List<string>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "quit")
                    break;

                string[] inputParams = inputLine.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                Worm currentWorm = new Worm();
                currentWorm.Name = inputParams[0].Trim();
                currentWorm.TeamName = inputParams[1].Trim();
                currentWorm.Score = long.Parse(inputParams[2].Trim());

                if (wormNames.Contains(currentWorm.Name))
                    continue;

                wormNames.Add(currentWorm.Name);

                if (!wormsDict.ContainsKey(currentWorm.TeamName))
                    wormsDict[currentWorm.TeamName] = new List<Worm>();

                wormsDict[currentWorm.TeamName].Add(currentWorm);
            }

            int count = 1;

            foreach (var team in wormsDict
                .OrderByDescending(x => x.Value.Sum(y => y.Score))
                .ThenByDescending(x => x.Value.Sum(y => y.Score) / x.Value.Count))
            {
                Console.WriteLine($"{count++}. Team: {team.Key} - {team.Value.Sum(y => y.Score)}");

                foreach (var worm in team.Value.OrderByDescending(x => x.Score))
                {
                    Console.WriteLine($"###{worm.Name} : {worm.Score}");
                }
            }
        }
    }
}
