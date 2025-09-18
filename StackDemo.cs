using System;
using System.Collections.Generic;

namespace NetcentricPracticals
{
    public class Stack<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("Stack is empty");
            T value = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return value;
        }

        public void Display()
        {
            Console.WriteLine("Stack contents:");
            if (items.Count == 0)
            {
                Console.WriteLine("(empty)");
                return;
            }
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class StackDemo
    {
        public static void Main()
        {
            // Integer stack
            var intStack = new Stack<int>();
            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);
            intStack.Display();

            Console.WriteLine("Popped: " + intStack.Pop());
            intStack.Display(); // show remaining stack

            // String stack
            var stringStack = new Stack<string>();
            stringStack.Push("Hello");
            stringStack.Push("Every");
            stringStack.Push("Nyan");
            stringStack.Display();

            Console.WriteLine("Popped: " + stringStack.Pop());
            stringStack.Display(); // show remaining stack
        }
    }
}
