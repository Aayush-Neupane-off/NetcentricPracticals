using System;

namespace NetcentricPracticals
{
    public class ExceptionDemo
    {
        public static void Main()
        {
            try
            {
                int x = 10;
                int y = 0;
                int result = x / y;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
                Console.WriteLine($"Exception details: {ex.Message}");
            }
        }
    }
}
