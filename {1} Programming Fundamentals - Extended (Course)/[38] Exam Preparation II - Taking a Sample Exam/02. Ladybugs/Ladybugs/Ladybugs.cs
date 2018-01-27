using System;
using System.Linq;

namespace Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] fields = new int[fieldSize];
            int[] indexesOfLadybigs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var index in indexesOfLadybigs)
            {
                if (index >= 0 && index < fields.Length) fields[index] = 1;                
            }

            while (true)
            {
                string comand = Console.ReadLine();

                if (comand == "end") break;                

                string[] input = comand
                    .Split();

                int ladybugIndex = int.Parse(input[0]);
                string direction = input[1];
                int flyLenght = int.Parse(input[2]);

                if (ladybugIndex < 0 || ladybugIndex >= fields.Length || fields[ladybugIndex] == 0) continue;                

                fields[ladybugIndex] = 0;
                int landingIndex = ladybugIndex;

                while (true)
                {
                    if (direction == "right") landingIndex += flyLenght;                    
                    else landingIndex -= flyLenght;                    

                    if (landingIndex < 0 || landingIndex >= fields.Length) break;                    

                    if (fields[landingIndex] == 0)
                    {
                        fields[landingIndex] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", fields));
        }
    }
}
