using System;
using System.Collections.Generic;

namespace Shellbound
{
    public class Shellbound
    {
        public static void Main()
        {
            Dictionary<string, HashSet<int>> regions = new Dictionary<string, HashSet<int>>();

            string input = Console.ReadLine();

            while (input != "Aggregate")
            {
                string[] tokens = input.Split(' ');

                string regionName = tokens[0];
                int size = int.Parse(tokens[1]);

                if (!regions.ContainsKey(regionName))
                {
                    regions[regionName] = new HashSet<int>();
                }

                regions[regionName].Add(size);

                input = Console.ReadLine();
            }

            int shellsSize, giantShellSize, count;
            GiantShell(out shellsSize, out giantShellSize, out count);

            foreach (var region in regions)
            {
                foreach (var shell in region.Value)
                {
                    count++;
                    shellsSize += shell;

                    giantShellSize = shellsSize - shellsSize / count;
                }

                Console.Write(region.Key + " -> ");

                Console.Write(string.Join(", ", region.Value) + " (" + giantShellSize + ")");

                Console.WriteLine();

                GiantShell(out shellsSize, out giantShellSize, out count);
            }
        }

        public static void GiantShell(out int shellsSize, out int giantShellSize, out int count)
        {
            shellsSize = 0;
            giantShellSize = 0;
            count = 0;
        }
    }
}
