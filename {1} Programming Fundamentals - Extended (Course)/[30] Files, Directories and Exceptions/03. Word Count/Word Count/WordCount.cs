using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Word_Count
{
    public class WordCount
    {
        public static void Main()
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split(' ');

            string[] text = File.ReadAllText("input.txt").ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordCount[word] = 0;
            }

            foreach (var word in text)
            {
                if (wordCount.ContainsKey(word)) wordCount[word]++;
            }

            foreach (var word in wordCount.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("output.txt", word.Key + " - " + word.Value + "\r\n");
            }
        }
    }
}
