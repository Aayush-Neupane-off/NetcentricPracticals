using System;

namespace NetcentricPracticals
{
    public partial class Studentt
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
