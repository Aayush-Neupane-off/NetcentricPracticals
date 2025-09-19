using System;
using System.IO;

namespace NetcentricPracticals
{
    public class TryFinallyDemo
    {
        public static void Main()
        {
            string path = "sample.txt";

            // If file doesn't exist, create it with some sample data
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "This is sample data inside sample.txt");
            }

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(path);
                Console.WriteLine("File contents:");
                Console.WriteLine(reader.ReadToEnd());
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    Console.WriteLine("File closed in finally block.");
                }
            }
        }
    }
}
