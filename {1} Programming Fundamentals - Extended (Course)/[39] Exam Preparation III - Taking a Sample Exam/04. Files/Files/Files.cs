using System;
using System.Collections.Generic;
using System.Linq;

namespace Files
{
    public class Files
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> dictionary = new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] currentFileData = Console.ReadLine().Split('\\');

                string fileRoot = currentFileData[0];

                string[] fileNameExtensionAndSize = currentFileData[currentFileData.Length - 1].Split(';');
                string fileNameAndExtension = fileNameExtensionAndSize[0];
                long fileSize = long.Parse(fileNameExtensionAndSize[1]);

                if (!dictionary.ContainsKey(fileRoot))
                {
                    dictionary[fileRoot] = new Dictionary<string, long>();
                }

                dictionary[fileRoot][fileNameAndExtension] = fileSize;
            }

            List<string> filesToSearch = Console.ReadLine().Split().ToList();
            string extension = filesToSearch[0];
            string root = filesToSearch[2];

            if (!dictionary.ContainsKey(root))
            {
                Console.WriteLine("No");
                Environment.Exit(1);
            }

            Dictionary<string, long> resultDictionary = dictionary[root]
              .Where(x => x.Key.EndsWith(extension))
              .OrderByDescending(x => x.Value)
              .ThenBy(x => x.Key)
              .ToDictionary(x => x.Key, y => y.Value); ;

            if (resultDictionary.Count == 0)
            {
                Console.WriteLine("No");
                Environment.Exit(1);
            }

            foreach (var file in resultDictionary)
            {
                Console.WriteLine($"{file.Key} - {file.Value} KB");
            }
        }
    }
}
