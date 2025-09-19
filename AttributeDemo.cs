using System;

namespace NetcentricPracticals
{
    [AttributeUsage(AttributeTargets.Class)]
    public class InfoAttribute : Attribute
    {
        public string Author { get; }
        public string Version { get; set; }

        public InfoAttribute(string author) // positional parameter
        {
            Author = author;
        }
    }

    [Info("Aayush", Version = "1.0")]
    public class SampleClass
    {
        public void Display()
        {
            Console.WriteLine("Inside SampleClass method");
        }
    }

    public class AttributeDemo
    {
        public static void Main()
        {
            var attributes = typeof(SampleClass).GetCustomAttributes(false);
            foreach (var attr in attributes)
            {
                if (attr is InfoAttribute info)
                {
                    Console.WriteLine($"Author: {info.Author}, Version: {info.Version}");
                }
            }
        }
    }
}
