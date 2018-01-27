using System;
using System.Collections.Generic;
using System.Linq;

namespace Track_Downloader
{
    public class TrackDownloader
    {
        public static void Main()
        {
            var blackList = Console.ReadLine()
                .Split(' ');

            var downloadedTracks = new List<string>();

            var line = Console.ReadLine();
            while (line != "end")
            {
                var isInBlacklist = false;

                foreach (var blacklistedWord in blackList)
                {
                    if (line.Contains(blacklistedWord))
                    {
                        isInBlacklist = true;
                        break;
                    }
                }

                if (!isInBlacklist)
                {
                    downloadedTracks.Add(line);
                }

                line = Console.ReadLine();
            }

            downloadedTracks.Sort();

            foreach (var track in downloadedTracks)
            {
                Console.WriteLine(track);
            }

        }
    }
}
