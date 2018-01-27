using System;
using System.Collections.Generic;
using System.Linq;

namespace Command_Interpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            List<string> array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(' ');

                string command = inputParams[0];

                switch (command)
                {
                    case "reverse":
                        int reverseStart = int.Parse(inputParams[2]);
                        int reverseCount = int.Parse(inputParams[4]);

                        if (IsValid(array, reverseStart, reverseCount))
                        {
                            Reverse(array, reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "sort":
                        int sortStart = int.Parse(inputParams[2]);
                        int sortCount = int.Parse(inputParams[4]);

                        if (IsValid(array, sortStart, sortCount))
                        {
                            Sort(array, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollLeft":
                        int rollLeftCount = int.Parse(inputParams[1]);

                        if (rollLeftCount >= 0)
                        {
                            RollLeftCount(array, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollRight":
                        int rollRightCount = int.Parse(inputParams[1]);

                        if (rollRightCount >= 0)
                        {
                            RollRightCount(array, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static bool IsValid(List<string> array, int start, int count)
        {
            bool result = start >= 0 && start < array.Count && count >= 0 && (start + count) <= array.Count;

            return result;
        }

        private static void RollRightCount(List<string> array, int rollRightCount)
        {
            int rotation = rollRightCount % array.Count;

            for (int i = 0; i < rotation; i++)
            {
                string lastElement = array[array.Count - 1];

                for (int j = array.Count - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];

                    //4 = lastElement
                    //1 2 3 4 
                    // 1 1 2 3
                    // 4 1 2 3
                }

                array[0] = lastElement;
            }
        }

        private static void RollLeftCount(List<string> array, int rollLeftCount)
        {
            int rotation = rollLeftCount % array.Count;

            for (int i = 0; i < rotation; i++)
            {
                string firstElement = array[0];

                for (int j = 0; j < array.Count - 1; j++)
                {
                    array[j] = array[j + 1];

                    //1 = firstElement
                    //1 2 3 4
                    //2 3 4 4
                    //2 3 4 1
                }

                array[array.Count - 1] = firstElement;
            }
        }

        private static void Sort(List<string> array, int sortStart, int sortCount)
        {
            array.Sort(sortStart, sortCount, null);
        }

        private static void Reverse(List<string> array, int reverseStart, int reverseCount)
        {
            array.Reverse(reverseStart, reverseCount);
        }
    }
}
