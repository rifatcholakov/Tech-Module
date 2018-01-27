using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Commits
{
    public class Commits
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"https:\/\/github.com\/([A-Za-z-0-9]+)\/([A-Za-z-_]+)\/commit\/([a-f0-9]{40}),(.+?)[,](\d+)[,](\d+)");

            SortedDictionary<string, SortedDictionary<string, List<Commit>>> result = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();

            while(input != "git push")
            {
                bool isMatch = regex.IsMatch(input);

                if (isMatch)
                {
                    Match match = regex.Match(input);

                    string username = match.Groups[1].Value;
                    string repo = match.Groups[2].Value;

                    Commit currentCommit = new Commit
                    {
                        hash = match.Groups[3].Value,
                        message = match.Groups[4].Value,
                        additions = decimal.Parse(match.Groups[5].Value),
                        deletions = decimal.Parse(match.Groups[6].Value)
                    };

                    if (!result.ContainsKey(username))
                    {
                        result[username] = new SortedDictionary<string, List<Commit>>();
                    }

                    if (!result[username].ContainsKey(repo))
                    {
                        result[username][repo] = new List<Commit>();
                    }

                    result[username][repo].Add(currentCommit);
                }

                input = Console.ReadLine();
            }

            foreach (var user in result)
            {
                Console.WriteLine($"{user.Key}:");

                foreach (var repo in user.Value)
                {
                    Console.WriteLine($"  {repo.Key}:");

                    decimal totalAdditions = repo.Value.Select(x => x.additions).Sum();
                    decimal totalDeletions = repo.Value.Select(x => x.deletions).Sum();

                    foreach (var commit in repo.Value)
                    {
                        Console.WriteLine($"    commit {commit.hash}: {commit.message} ({commit.additions} additions, {commit.deletions} deletions)");                      
                    }

                    Console.WriteLine($"    Total: {totalAdditions} additions, {totalDeletions} deletions");
                }                
            }
        }
    }
}
