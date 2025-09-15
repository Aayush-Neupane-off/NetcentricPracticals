using System;

namespace NetcentricPracticals
{
    class SealedClassDemo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Aadi", 50000);
            emp.DisplayInfo();

            Console.ReadLine();
        }
    }

    sealed class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee: {Name}, Salary: {Salary}");
        }
    }

    // ❌ This will cause error:
    // class Manager : Employee { }
}
