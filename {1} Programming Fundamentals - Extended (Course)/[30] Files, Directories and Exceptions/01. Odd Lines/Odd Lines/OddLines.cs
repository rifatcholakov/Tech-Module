using System.Linq;
using System.IO;

namespace Odd_Lines
{
    public class OddLines
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("input.txt");

            File.WriteAllLines("output.txt", text.Where((line, index) => index % 2 == 1));
        }
    }
}
