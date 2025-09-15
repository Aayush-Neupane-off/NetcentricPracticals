using System;

namespace NetcentricPracticals
{
    class ArraysDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of names: ");
            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\nYou entered:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
