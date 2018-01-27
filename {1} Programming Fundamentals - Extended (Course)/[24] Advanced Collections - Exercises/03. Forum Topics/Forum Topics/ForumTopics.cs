using System;
using System.Collections.Generic;

namespace Forum_Topics
{
    public class ForumTopics
    {
        public static void Main()
        {
            Dictionary<string, HashSet<string>> forum = new Dictionary<string, HashSet<string>>();

            string input = Console.ReadLine();

            while (input != "filter")
            {
                string[] tokens = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string topic = tokens[0];

                if (!forum.ContainsKey(topic))
                {
                    forum[topic] = new HashSet<string>();
                }

                for (int i = 1; i < tokens.Length; i++)
                {
                    forum[topic].Add(tokens[i]);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            string[] tags = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            bool contains = true;
            contains = DoesContainsTags(forum, tags, contains);
        }

        public static bool DoesContainsTags(Dictionary<string, HashSet<string>> forum, string[] tags, bool contains)
        {
            foreach (var topic in forum)
            {

                for (int i = 0; i < tags.Length; i++)
                {
                    contains = false;

                    if (topic.Value.Contains(tags[i]))
                    {
                        contains = true;
                    }
                    else
                    {
                        contains = false;
                        break;
                    }
                }

                if (contains)
                {
                    Console.Write(topic.Key + " | ");

                    int i = 1;

                    foreach (var tag in topic.Value)
                    {

                        if (i == topic.Value.Count)
                        {
                            Console.Write("#" + tag);

                        }
                        else
                        {
                            Console.Write("#" + tag + ", ");
                        }

                        i++;
                    }
                    Console.WriteLine();
                }
            }

            return contains;
        }
    }
}
