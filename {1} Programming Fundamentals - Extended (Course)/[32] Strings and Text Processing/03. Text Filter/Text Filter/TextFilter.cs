﻿using System;

namespace Text_Filter
{
    public class TextFilter
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
