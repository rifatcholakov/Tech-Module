using System;

namespace Nilapdromes
{
    public class Nilapdromes
    {
        public static void Main()
        {
            string border = string.Empty;
            string core = string.Empty;

            string input = Console.ReadLine();

            while (input != "end")
            {

                int borderLength = 0;
                int iterations = 0;

                for (int i = input.Length / 2; i > 0; --i)
                {
                    string currentBorder = input.Substring(0, i);
                    string otherBorder = input.Substring(input.Length - i);
              
                    if (currentBorder == otherBorder)
                    {
                        borderLength = i;
                        break;
                    }
                    ++iterations;
                }

                if (borderLength != 0 && (iterations != 0 || input.Length % 2 == 1))
                {
                    border = input.Substring(0, borderLength);

                    core = input.Substring(borderLength, input.Length - 2 * borderLength);

                    input = border + core + border;

                    string newNilapdrom = core + border + core;
                    Console.WriteLine(newNilapdrom);
                }

                input = Console.ReadLine();
            }
        }
    }
}
