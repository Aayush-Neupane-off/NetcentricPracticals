using System;
using System.IO;

namespace NetcentricPracticals
{
    public class FileIODemo
    {
        public static void Main()
        {
            string inputPath = "input.txt";
            string outputPath = "output.txt";

            // Create input file for demo
            File.WriteAllText(inputPath, "This is sample data from input.txt");

            using (StreamReader reader = new StreamReader(inputPath))
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Data copied from input.txt to output.txt");
        }
    }
}
