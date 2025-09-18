using System;

namespace NetcentricPracticals
{
    public partial class Studentt
    {
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }
    }

    public class PartialClassDemo
    {
        public static void Main()
        {
            Studentt s = new Studentt { Name = "Aayush", Age = 21 };
            s.DisplayInfo();
            s.Greet();
        }
    }
}
