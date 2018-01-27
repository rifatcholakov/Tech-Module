using System.Linq;
using System.IO;

namespace Re_Directory
{
    public class ReDirectory
    {
        public static void Main()
        {
            string path = "input";

            string[] files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                string[] fileParts = file.Split('.').Reverse().ToArray();
                string fileExtension = fileParts[0];

                string[] fileNameParts = file.Split('\\').Reverse().ToArray();
                string fileName = fileNameParts[0];

                string outputPath = "output/" + fileExtension + "s/" + fileName;
                string outputDirectory = "output/" + fileExtension + "s";

                string filePath = file;

                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }

                Directory.Move(filePath, outputPath);
            }
        }
    }
}
