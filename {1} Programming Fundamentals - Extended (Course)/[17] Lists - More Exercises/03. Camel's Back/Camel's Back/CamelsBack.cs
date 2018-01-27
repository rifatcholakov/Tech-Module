using System;
using System.Collections.Generic;
using System.Linq;

namespace Camel_s_Back
{
    public class CamelsBack

    {
        public static void Main()
        {
            List<int> buildings = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int size = int.Parse(Console.ReadLine());

            int count = 0;

            if (size == buildings.Count)
            {
                Console.Write("already stable: ");
                Buildings(buildings);

            }
            else
            {

                while (size < buildings.Count)
                {
                    buildings.RemoveAt(0);
                    buildings.RemoveAt(buildings.Count - 1);

                    count++;
                }

                Console.WriteLine($"{count} rounds");
                Console.Write("remaining: ");
                Buildings(buildings);
            }

        }

        public static void Buildings(List<int> buildings)
        {
            foreach (var building in buildings)
            {
                Console.Write(building + " ");
            }
        }
    }
}

