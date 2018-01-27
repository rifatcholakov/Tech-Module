using System;
using System.Linq;

namespace Hornet_Assault
{
    public class HornetAssault
    {
        public static void Main()
        {
            long[] beehives = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            long[] hornets = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            long power = hornets.Sum();
            long currentFirstHornetIndex = 0;

            for (int i = 0; i < beehives.Length; i++)
            {
                long bees = beehives[i];

                if (bees >= power)
                {
                    beehives[i] -= power;
                    if (currentFirstHornetIndex < hornets.Length)
                    {
                        power -= hornets[currentFirstHornetIndex];
                        currentFirstHornetIndex++;
                    }
                }
                else
                {
                    beehives[i] -= power;
                }
            }

            if(beehives.Any(b => b > 0))
            {
                long[] result = beehives.Where(b => b > 0).ToArray();
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                var resul = hornets.Skip((int)currentFirstHornetIndex);
                Console.WriteLine(string.Join(" ", resul));
            }
        }
    }
}
