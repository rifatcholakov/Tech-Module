using System;
using System.Collections.Generic;

namespace Dict_Ref
{
    public class DictRef

    {
        public static void Main()
        {
            Dictionary<string, int> resultDict = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split();

                string firstElement = tokens[0];
                string lastElement = tokens[tokens.Length - 1];

                int number = 0;

                if (int.TryParse(lastElement, out number))
                {
                    resultDict[firstElement] = number;
                }
                else
                {
                    if (resultDict.ContainsKey(lastElement))
                    {
                        int referencedValue = resultDict[lastElement];
                        resultDict[firstElement] = referencedValue;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in resultDict)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }

        }
    }
}
