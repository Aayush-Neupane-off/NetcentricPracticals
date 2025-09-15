using System;
using System.Linq;

namespace NetcentricPracticals
{
    class StringReverseDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reversed = new string(charArray);
                Console.WriteLine($"Reversed String: {reversed}");
            }
            else
            {
                Console.WriteLine("No input provided.");
            }

            Console.ReadLine(); // Keep the console window open
        }
    }
}