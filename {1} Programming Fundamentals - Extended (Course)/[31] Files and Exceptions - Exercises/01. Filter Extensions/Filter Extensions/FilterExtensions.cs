using System;
using System.Linq;
using System.IO;

namespace Filter_Extensions
{
    public class FilterExtensions
    {
        public static void Main()
        {
            string extension = Console.ReadLine();

            DirectoryInfo directoryInfo = new DirectoryInfo("input");

            FileInfo[] files = directoryInfo.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                string[] fileParts = files[i].ToString().Split('.').Reverse().ToArray();

                if (fileParts[0] == extension)
                {
                    File.AppendAllText("output.txt", files[i] + "\r\n");
                    Console.WriteLine(files[i]);
                }                
            }
        }
    }
}
