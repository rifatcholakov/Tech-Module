using System;

namespace Sentence_Split
{
    public class SentenceSplit
    {
        public static void Main()
        {
            string secntence = Console.ReadLine();
            string delimiter = Console.ReadLine();

            string[] splitedSentence = secntence
                .Split(new string[] { delimiter }, StringSplitOptions.None);

            Console.WriteLine("[" + string.Join(", ", splitedSentence) + "]");
        }
    }
}
