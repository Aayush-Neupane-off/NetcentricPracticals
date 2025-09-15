using System;

namespace NetcentricPracticals
{
    class MethodHidingDemo
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.Drive();

            Car c = new Car();
            c.Drive();

            Vehicle vc = new Car(); // Calls base method because of hiding
            vc.Drive();

            Console.ReadLine();
        }
    }

    class Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a vehicle...");
        }
    }

    class Car : Vehicle
    {
        public new void Drive()  // method hiding
        {
            Console.WriteLine("Driving a car...");
        }
    }
}
