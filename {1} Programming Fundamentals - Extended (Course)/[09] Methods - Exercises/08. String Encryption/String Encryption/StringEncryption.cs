using System;

namespace String_Encryption
{
    public class StringEncryption
    {
        public static void Main()
        {
            int characterNumbers = int.Parse(Console.ReadLine());

            string result = String.Empty;

            for (int i = 0; i < characterNumbers; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                result += StartingChar(letter) + FirstDigit(letter) + LastDigit(letter) + EndingChar(letter);
            }
            Console.WriteLine(result);

        }
        public static string FirstDigit(char letter)
        {
            int firstDigit = letter;

            while (firstDigit >= 10)
            {
                firstDigit /= 10;     
            }

            return firstDigit.ToString();
        }
        public static string LastDigit(char letter)
        {
            int lastDigit = letter;

            lastDigit %= 10;

            return lastDigit.ToString();
        }
        public static string StartingChar(char letter)
        {
            int asciiCode = letter;
            int startingCharacter = asciiCode + int.Parse(LastDigit(letter));

            char result = (char)startingCharacter;

            return result.ToString();
        }
        public static string EndingChar(char letter)
        {
            int asciiCode = letter;
            int endingCharacter = asciiCode - int.Parse(FirstDigit(letter));

            char result = (char)endingCharacter;

            return result.ToString();
        }
    }
}
