using System;
using System.Collections.Generic;
using System.Linq;

namespace Pyramidic
{
    public class Pyramidic
    {
        public static void Main()
        {            
            int n = int.Parse(Console.ReadLine());

            List<string> pyramids = new List<string>();

            string[] lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    char currentCharacter = currentLine[j];
                    int layer = 1;
                    string currentPyramid = "";

                    for (int k = i; k < lines.Length; k++)
                    {
                        string currentLayer = new string(currentCharacter, layer);

                        if (lines[k].Contains(currentLayer))
                        {
                            currentPyramid += currentLayer + Environment.NewLine;
                        }
                        else
                        {
                            break;
                        }

                        layer += 2;
                    }

                    pyramids.Add(currentPyramid.Trim());
                }
            }

            Console.WriteLine(pyramids.OrderByDescending(x => x.Length).First());
        }
    }
}
