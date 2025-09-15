using System;

namespace NetcentricPracticals
{
    class IndexerBookDemo
    {
        static void Main(string[] args)
        {
            Book book = new Book("C# Basics", "Kalamkar", "1300");

            Console.WriteLine("Book Details:");
            Console.WriteLine($"Title: {book[0]}");
            Console.WriteLine($"Author: {book[1]}");
            Console.WriteLine($"Price: {book[2]}");

            Console.ReadLine();
        }
    }

    class Book
    {
        private string[] properties = new string[3];

        public Book(string title, string author, string price)
        {
            properties[0] = title;
            properties[1] = author;
            properties[2] = price;
        }

        // Indexer
        public string this[int index]
        {
            get { return properties[index]; }
            set { properties[index] = value; }
        }
    }
}
