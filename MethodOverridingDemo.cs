using System;

namespace NetcentricPracticals
{
    class MethodOverridingDemo
    {
        static void Main(string[] args)
        {
            Animal a1 = new Cat();
            Animal a2 = new Dog();

            a1.MakeSound();  // Cat sound
            a2.MakeSound();  // Dog sound

            Console.ReadLine();
        }
    }

    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow, Meowing ");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof, Dogging");
        }
    }
}
