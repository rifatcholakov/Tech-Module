using System;
using System.Collections.Generic;

namespace Social_Media_Posts
{
    public class SocialMediaPosts
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, List<string>>> commentsDB = new Dictionary<string, Dictionary<string, List<string>>>();
            Dictionary<string, int> likesDB = new Dictionary<string, int>();
            Dictionary<string, int> dislikesDB = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "drop the media")
            {
                string[] tokens = input.Split(' ');

                string command = tokens[0];

                if (!likesDB.ContainsKey(tokens[1]))
                {
                    likesDB[tokens[1]] = 0;
                }

                if (!dislikesDB.ContainsKey(tokens[1]))
                {
                    dislikesDB[tokens[1]] = 0;
                }

                switch (command)
                {
                    case "post":
                        commentsDB[tokens[1]] = new Dictionary<string, List<string>>();
                        break;

                    case "like":
                        likesDB[tokens[1]] += 1;
                        break;

                    case "dislike":
                        dislikesDB[tokens[1]] += 1;
                        break;

                    case "comment":
                        commentsDB[tokens[1]].Add(tokens[2], new List<string>());

                        for (int i = 3; i < tokens.Length; i++)
                        {
                            commentsDB[tokens[1]][tokens[2]].Add(tokens[i]);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var post in commentsDB)
            {
                Console.WriteLine($"Post: {post.Key} | Likes: {likesDB[post.Key]} | Dislikes: {dislikesDB[post.Key]}");
                Console.WriteLine("Comments:");
                Dictionary<string, List<string>> comments = post.Value;

                if (post.Value.Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var comment in comments)
                    {
                        Console.WriteLine("*  {0}: {1}", comment.Key, String.Join(" ", comment.Value));
                    }
                }
            }
        }
    }
}
