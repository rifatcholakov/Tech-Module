using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Phone
{
    public class Phone
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine()
                .Split(' ');

            string[] names = Console.ReadLine()
                .Split(' ');

            string name = string.Empty;

            string number = string.Empty;

            while (true)
            {
                string[] call = Console.ReadLine()
                    .Split(' ');

                for (long i = 0; i < call.Length; i++)
                {
                    if (call[i].Equals("done"))
                    {
                        return;
                    }
                }

                for (long j = 0; j < names.Length; j++)
                {

                    if (call[0].Equals("call") && call[1].Equals(names[j]) || call[0].Equals("call") && call[1].Equals(numbers[j]))
                    {
                        name = names[j];
                        number = numbers[j];

                        if (call[1].Equals(numbers[j]))
                        {
                            Console.WriteLine("calling " + name + "...");
                        } else
                        {
                            Console.WriteLine("calling " + number + "...");
                        }

                        long residue = 0;

                        number = Regex.Replace(number, "[^0-9]+", string.Empty);

                        long numberToLong = long.Parse(number);

                        while (numberToLong > 0)
                        {
                            residue += numberToLong % 10;
                            numberToLong /= 10;
                        }

                        long duration = residue;

                        long minutes = 0;

                        while(duration > 59)
                        {
                            minutes++;
                            duration -= 60;
                        }

                        long seconds = duration;

                        TimeSpan timeSpan = new TimeSpan(0, (int)minutes, (int)seconds);


                        if (residue % 2 == 0)
                        {
                            Console.WriteLine("call ended. duration: {0:mm\\:ss}", timeSpan);
                        }
                        else
                        {
                            Console.WriteLine("no answer.");
                        }

                    }

                    if (call[0].Equals("message") && call[1].Equals(names[j]) || call[0].Equals("message") && call[1].Equals(numbers[j]))
                    {
                        name = names[j];
                        number = numbers[j];

                        if (call[1].Equals(numbers[j]))
                        {
                            Console.WriteLine("sending sms to " + name + "...");
                        }
                        else
                        {
                            Console.WriteLine("sending sms to " + number + "...");
                        }

                        long residue = 0;

                        number = Regex.Replace(number, "[^0-9]+", string.Empty);

                        long numberToLong = long.Parse(number);

                        while (numberToLong > 0)
                        {
                            residue -= numberToLong % 10;
                            numberToLong /= 10;
                        }

                        if (residue % 2 == 0)
                        {
                            Console.WriteLine("meet me there");
                        }
                        else
                        {
                            Console.WriteLine("busy");
                        }

                    }

                }

            }

        }

    }
}

