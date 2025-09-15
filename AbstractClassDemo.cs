using System;

namespace NetcentricPracticals
{
    class AbstractClassDemo
    {
        static void Main(string[] args)
        {
            Shapee circlee = new Circlee(7);
            Shapee rectanglee = new Rectanglee(6, 9);

            Console.WriteLine($"Area of the circle is : {circlee.CalculateArea()}");
            Console.WriteLine($"Area of the rectangle is : {rectanglee.CalculateArea()}");

            Console.ReadLine();
        }
    }

    abstract class Shapee
    {
        public abstract double CalculateArea();
    }

    class Circlee : Shapee
    {
        private double radius;
        public Circlee(double r) { radius = r; }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectanglee : Shapee
    {
        private double width, height;
        public Rectanglee(double w, double h)
        {
            width = w; height = h;
        }

        public override double CalculateArea()
        {
            return width * height;
        }
    }
}
