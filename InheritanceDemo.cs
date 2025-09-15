using System;

namespace NetcentricPracticals
{
    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            Shape s1 = new Circle();
            Shape s2 = new Rectangle();

            s1.Draw();
            s2.Draw();

            Console.ReadLine();
        }
    }

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape...");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
}
