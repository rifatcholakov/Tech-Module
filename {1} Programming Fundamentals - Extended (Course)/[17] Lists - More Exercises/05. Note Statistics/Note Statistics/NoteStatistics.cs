using System;
using System.Collections.Generic;
using System.Linq;

namespace Note_Statistics
{
    public class NoteStatistics
    {
        public static void Main()
        {
            List<double> input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            List<double> frequencies = new List<double>(new double[] { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 });
            List<string> letter = new List<string>(new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" });

            string notes = string.Empty;
            string sharp = string.Empty;
            string natural = string.Empty;

            List<double> sharpFrequencies = new List<double>();
            List<double> naturalFrequencies = new List<double>();

            for (int i = 0; i < input.Count; i++)
            {

                if (frequencies.Contains(input[i]))
                {
                    int index = frequencies.FindIndex(u => u == input[i]);

                    notes += letter[index] + " ";

                    if (letter[index].Contains("#"))
                    {
                        sharp += letter[index] + " ";
                        sharpFrequencies.Add(frequencies[index]);
                    } else
                    {
                        natural += letter[index] + " ";
                        naturalFrequencies.Add(frequencies[index]);
                    }

                }

            }

            notes = notes.TrimEnd();
            natural = natural.TrimEnd();
            sharp = sharp.TrimEnd();

            List<string> notesList = notes.Split(new char[] { ' ' }).ToList();
            List<string> naturalList = natural.Split(new char[] { ' ' }).ToList();
            List<string> sharpList = sharp.Split(new char[] { ' ' }).ToList();

                double naturalSum = 0;
                double sharpSum = 0;

            foreach (var number in naturalFrequencies)
            {
                naturalSum += number;
            }

            foreach (var number in sharpFrequencies)
            {
                sharpSum += number; 
            }

            Console.WriteLine("Notes: " + string.Join(" ", notesList));
            Console.WriteLine("Naturals: " + string.Join(", ", naturalList));
            Console.WriteLine("Sharps: " + string.Join(", ", sharpList));

            Console.WriteLine("Naturals sum: " + naturalSum);
            Console.WriteLine("Sharps sum: " + sharpSum);
        }
    }
}
