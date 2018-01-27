using System;
using System.Collections.Generic;
using System.Linq;

namespace Roli_The_Coder
{

    public class RoliTheCoder
    {
        public static void Main()
        {

            string input = Console.ReadLine();

            SortedDictionary<int, SortedDictionary<string, List<string>>> eventList = new SortedDictionary<int, SortedDictionary<string, List<string>>>();


            while (!input.Equals("Time for Code"))
            {
                string[] inputArgs = input.Split(new char[] { ' ' },
                            StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

                int id = int.Parse(inputArgs[0]);
                string eventWithHash = inputArgs[1];
                string eventName = inputArgs[1].Substring(1);
                List<string> participants = new List<string>(inputArgs.Skip(2));

                if (eventWithHash[0] != '#')
                {
                    goto inpt;
                }
                if (!eventList.ContainsKey(id))
                {
                    eventList.Add(id, new SortedDictionary<string, List<string>>());
                }
                else if (!eventList[id].ContainsKey(eventName))
                {
                    goto inpt;
                }

                if (eventList[id].ContainsKey(eventName))
                {
                    foreach (string participant in participants)
                    {
                        if (!eventList[id][eventName].Contains(participant))
                        {
                            eventList[id][eventName].Add(participant);
                        }
                    }
                    goto inpt;
                }
                eventList[id][eventName] = participants.Distinct().ToList();

                inpt:
                input = Console.ReadLine();

            }

            foreach (var res in eventList.OrderByDescending(x => x.Value.Values.Sum(y => y.Count)))
            {
                List<string> helper = new List<string>();
                foreach (var meet in res.Value)
                {
                    helper = meet.Value.Distinct().ToList();
                    helper.Sort();
                    int count = helper.Count;
                    Console.WriteLine("{0} - {1}", meet.Key, count);
                }
                foreach (var help in helper)
                {
                    Console.WriteLine("{0}", help);
                }
            }
        }
    }
}

