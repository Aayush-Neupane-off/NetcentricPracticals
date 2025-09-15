using System;
using System.IO;

namespace NetcentricPracticals
{
    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger("log.txt");
            logger.Log("This is a log message.");
            Console.WriteLine("Log written to file.");

            Console.ReadLine();
        }
    }

    interface ILogger
    {
        void Log(string message);
    }

    class FileLogger : ILogger
    {
        private string filePath;

        public FileLogger(string path)
        {
            filePath = path;
        }

        public void Log(string message)
        {
            File.AppendAllText(filePath, message + Environment.NewLine);
        }
    }
}
