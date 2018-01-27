using System;
using System.Linq;

namespace Multiply_an_Array_of_Doubles
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

            double p = double.Parse(Console.ReadLine());
            
            for (int i = 0; i < text.Length; i++)
            {
                text[i] *= p;
                Console.Write(text[i] + " ");
            }
        }
    }
}
