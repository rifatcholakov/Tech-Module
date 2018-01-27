using System;
using System.Linq;

namespace Array_Manipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    break;
                }

                string[] comandLine = inputLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string comand = comandLine[0];
                switch (comand)
                {
                    case "exchange":
                        int index = int.Parse(comandLine[1]);

                        if (index < 0 || index >= arr.Length)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        int[] leftPart = arr.Take(index + 1).ToArray();
                        int[] rightPart = arr.Skip(index + 1).ToArray();
                        arr = rightPart.Concat(leftPart).ToArray();

                        break;

                    case "max":
                    case "min":
                        string maxOrMin = comand;
                        string evenOrOdd = comandLine[1];

                        GetIndexOfElement(arr, maxOrMin, evenOrOdd);
                        break;

                    case "first":
                    case "last":
                        string firstOrLast = comand;
                        int count = int.Parse(comandLine[1]);
                        evenOrOdd = comandLine[2];

                        ReturnCounElements(arr, firstOrLast, count, evenOrOdd);
                        break;
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }

        private static void ReturnCounElements(int[] arr, string firstOrLast, int count, string evenOrOdd)
        {
            if (count < 0 || count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int result = evenOrOdd == "even" ? 0 : 1;
            int[] evenOrOddElements = arr.Where(s => s % 2 == result).ToArray();
            int[] lastOrFirstArr = firstOrLast == "first" ? evenOrOddElements.Take(count).ToArray() : evenOrOddElements.Reverse().Take(count).Reverse().ToArray();

            Console.WriteLine("[{0}]", string.Join(", ", lastOrFirstArr));

            return;
        }

        private static void GetIndexOfElement(int[] arr, string maxOrMin, string evenOrOdd)
        {
            int result = evenOrOdd == "even" ? 0 : 1;
            int[] evenOrOddElements = arr.Where(s => s % 2 == result).ToArray();

            if (evenOrOddElements.Length == 0)
            {
                Console.WriteLine("No matches");
                return;
            }

            int maxOrMinElement = maxOrMin == "max" ? evenOrOddElements.Max() : evenOrOddElements.Min();
            int lastIndexOfElement = Array.LastIndexOf(arr, maxOrMinElement);

            Console.WriteLine(lastIndexOfElement);

            return;
        }
    }
}
