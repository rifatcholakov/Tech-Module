using System.Linq;
using System.IO;

namespace Merge_Files
{
    public class MergeFiles
    {
        public static void Main()
        {
            string[] firstFile = File.ReadAllLines("Input1.txt");
            string[] secondFile = File.ReadAllLines("Input2.txt");

            File.AppendAllLines("Output.txt", firstFile);

            File.AppendAllLines("Output.txt", secondFile);

            string[] appendedFile = File.ReadAllLines("output.txt");

            File.WriteAllLines("Output.txt", appendedFile.OrderBy(x => x));
        }
    }
}
