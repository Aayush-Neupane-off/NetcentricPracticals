using System;

namespace NetcentricPracticals
{
    class ConstructorsDemo
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Aayush Neupane", 21);
            s1.Display();
            Console.ReadLine();
        }
    }

    class Student
    {
        public string Name;
        public int Age;

        // Constructor
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
