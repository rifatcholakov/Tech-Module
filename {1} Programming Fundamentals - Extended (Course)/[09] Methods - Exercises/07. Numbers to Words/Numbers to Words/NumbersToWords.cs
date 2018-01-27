using System;

namespace Numbers_to_Words
{
    public class NumbersToWords
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(Letterize(num));
            }
        }

        static string Letterize(int number)
        {
            if (number < -999)
            {
                return "too small";
            }

            if (number > 999)
            {
                return "too large";
            }

            if (Math.Abs(number).ToString().Length != 3)
            {
                return string.Empty;
            }

            var result = string.Empty;

            if (number < 0)
            {
                result += "minus ";
            }

            number = Math.Abs(number);

            int firstDigit = number;
            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }

            string digitFirstWord = DigitToWord(firstDigit);

            digitFirstWord += "-hundred";
            result += digitFirstWord;

            int lastPart = number % 100;
            string stringLastPart = string.Empty;

            if (lastPart == 0)
            {
                return result;
            }

            stringLastPart = DigitToTeenNumberWord(lastPart);

            if (stringLastPart != string.Empty)
            {
                result += $" and {stringLastPart}";
                return result;
            }

            int secondDigit = lastPart / 10 % 10;
            stringLastPart = DigitToTensWord(secondDigit);

            result += $" and {stringLastPart}";
            bool isTeenNumber = lastPart >= 11 && lastPart <= 19;

            int lastDigit = lastPart % 10;
            string stringLastDigit = string.Empty;
            if (lastDigit != 0 && !isTeenNumber)
            {
                stringLastDigit = DigitToWord(lastDigit);
            }

            string space = string.Empty;
            if (lastDigit != 0 && secondDigit != 0)
            {
                space = " ";
            }

            result += $"{space}{stringLastDigit}";

            return result;
        }

        static string DigitToWord(int lastDigit)
        {
            string stringLastDigit;
            switch (lastDigit)
            {
                case 1:
                    stringLastDigit = "one";
                    break;
                case 2:
                    stringLastDigit = "two";
                    break;
                case 3:
                    stringLastDigit = "three";
                    break;
                case 4:
                    stringLastDigit = "four";
                    break;
                case 5:
                    stringLastDigit = "five";
                    break;
                case 6:
                    stringLastDigit = "six";
                    break;
                case 7:
                    stringLastDigit = "seven";
                    break;
                case 8:
                    stringLastDigit = "eight";
                    break;
                case 9:
                    stringLastDigit = "nine";
                    break;
                default:
                    stringLastDigit = string.Empty;
                    break;
            }

            return stringLastDigit;
        }

        static string DigitToTensWord(int secondDigit)
        {
            string stringLastPart;
            switch (secondDigit)
            {
                case 1:
                    stringLastPart = "ten";
                    break;
                case 2:
                    stringLastPart = "twenty";
                    break;
                case 3:
                    stringLastPart = "thirty";
                    break;
                case 4:
                    stringLastPart = "fourty";
                    break;
                case 5:
                    stringLastPart = "fifty";
                    break;
                case 6:
                    stringLastPart = "sixty";
                    break;
                case 7:
                    stringLastPart = "seventy";
                    break;
                case 8:
                    stringLastPart = "eighty";
                    break;
                case 9:
                    stringLastPart = "ninety";
                    break;
                default:
                    stringLastPart = string.Empty;
                    break;
            }

            return stringLastPart;
        }

        static string DigitToTeenNumberWord(int lastPart)
        {
            string stringLastPart;
            switch (lastPart)
            {
                case 11:
                    stringLastPart = "eleven";
                    break;
                case 12:
                    stringLastPart = "twelve";
                    break;
                case 13:
                    stringLastPart = "thirteen";
                    break;
                case 14:
                    stringLastPart = "fourteen";
                    break;
                case 15:
                    stringLastPart = "fifteen";
                    break;
                case 16:
                    stringLastPart = "sixteen";
                    break;
                case 17:
                    stringLastPart = "seventeen";
                    break;
                case 18:
                    stringLastPart = "eighteen";
                    break;
                case 19:
                    stringLastPart = "nineteen";
                    break;
                default:
                    stringLastPart = string.Empty;
                    break;
            }

            return stringLastPart;
        }
    }
}
