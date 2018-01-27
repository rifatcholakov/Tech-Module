using System;
using System.Collections.Generic;

namespace Exam_Shopping
{
    public class ExamShopping
    {
        public static void Main()
        {
            Dictionary<string, int> shop = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "shopping time")
            {
                string[] tokens = input.Split(' ');

                string itemName = tokens[1];
                int quantity = int.Parse(tokens[2]);

                if (shop.ContainsKey(itemName))
                {
                    shop[itemName] += quantity;
                }
                else
                {
                    shop[itemName] = quantity;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while(input != "exam time")
            {
                string[] tokens = input.Split(' ');

                string itemName = tokens[1];
                int quantity = int.Parse(tokens[2]);

                if (shop.ContainsKey(itemName))
                {
                    if(quantity <= shop[itemName])
                    {
                        shop[itemName] -= quantity;
                    }
                    else if (shop[itemName] == 0)
                    {
                        Console.WriteLine(itemName + " out of stock");
                    }
                    else if(quantity > shop[itemName])
                    {
                        shop[itemName] = 0;
                    }
                    
                }
                else
                {
                    Console.WriteLine(itemName + " doesn't exist");
                }

                input = Console.ReadLine();
            }

            foreach (var item in shop)
            {
                if(item.Value > 0)
                {
                    Console.WriteLine(item.Key + " -> " + item.Value);
                }
            }

        }
    }
}
