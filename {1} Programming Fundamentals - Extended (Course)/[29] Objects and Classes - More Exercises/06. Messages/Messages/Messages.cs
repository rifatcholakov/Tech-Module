using System;
using System.Collections.Generic;
using System.Linq;

namespace Messages
{
    public class Messages
    {
        public static void Main()
        {
            List<User> usersList = new List<User>();

            string input = Console.ReadLine();
            while (input != "exit")
            {
                string[] inputParts = input.Split(' ').ToArray();

                if (inputParts[0] == "register")
                {
                    User currentUser = new User()
                    {
                        username = inputParts[1],
                        receivedMessages = new List<Message>()
                    };

                    if (!usersList.Contains(currentUser))
                    {
                        usersList.Add(currentUser);
                    }
                }
                else
                {
                    string senderName = inputParts[0];
                    string recipientUsername = inputParts[2];

                    Message currentMessage = new Message
                    {
                        content = inputParts[3],
                        sender = new User() { username = senderName, receivedMessages = new List<Message>() }
                    };
                    
                    User[] ifContainsSender = usersList.Where(x => x.username == senderName).ToArray();
                    User[] ifContainsRecipient = usersList.Where(x => x.username == recipientUsername).ToArray();

                    if (ifContainsSender.Count() > 0 && ifContainsRecipient.Count() > 0)
                    {
                        User recipientMessages = usersList.FirstOrDefault(x => x.username == recipientUsername);
                        if (recipientMessages != null)
                        {
                            recipientMessages.receivedMessages.Add(currentMessage);
                        }
                    }
                }

                input = Console.ReadLine();
            }
            string[] finalInputParts = Console.ReadLine().Split(' ').ToArray();
            string first = finalInputParts[0];
            string second = finalInputParts[1];

            int messagesFromFirstToSecond = usersList
                .Where(x => x.username == second)
                .SelectMany(x => x.receivedMessages)
                .Where(x => x.sender.username == first)
                .Count();
            int messagesFromSecondToFirst = usersList
                .Where(x => x.username == first)
                .SelectMany(x => x.receivedMessages)
                .Where(x => x.sender.username == second)
                .Count();

            if (messagesFromFirstToSecond == 0 && messagesFromSecondToFirst == 0)
            {
                Console.WriteLine("No messages");

            }
            else
            {
                for (int i = 0; i < Math.Max(messagesFromFirstToSecond, messagesFromSecondToFirst); i++)
                {
                    if (i < messagesFromFirstToSecond)
                    {
                        Console.WriteLine($"{first}: {usersList.Where(x => x.username == second).SelectMany(x => x.receivedMessages).Where(x => x.sender.username == first).Select(x => x.content).ToList()[i]}");
                    }
                    if (i < messagesFromSecondToFirst)
                    {
                        Console.WriteLine($"{usersList.Where(x => x.username == first).SelectMany(x => x.receivedMessages).Where(x => x.sender.username == second).Select(x => x.content).ToList()[i]} :{second}");
                    }

                }
            }
        }
    }
}