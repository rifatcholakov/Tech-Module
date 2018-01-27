using System;
using System.Linq;

namespace console
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            IntegerToBase(number, toBase);
        }
        public static void IntegerToBase(int number, int toBase)
        {   
            string result = string.Empty;
            while (number > 0)
            {
                int residue = number % toBase;

                number /= toBase;
                result += residue.ToString();
            }
            foreach (var reversedResult in result.Reverse())
            {
                Console.Write(reversedResult);
            }
        }
    }
}