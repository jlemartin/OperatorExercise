using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part #1
            Console.WriteLine("Part 1 of Exercise:");

            int a = 17;
            int b = 4;

            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            int division = a / b;
            int remainder = a % b;

            Console.WriteLine($"The sum of {a} and {b} is {addition}.");
            Console.WriteLine($"The difference of {a} and {b} is {subtraction}.");
            Console.WriteLine($"The product of {a} and {b} is {multiplication}.");
            Console.WriteLine($"{a} divided by {b} is {division}.");
            Console.WriteLine($"The remainder when {a} is divided by {b} is {remainder}.");
            Console.WriteLine($"Thus, {a} / {b} is {division} with a remainder of {remainder}.");
            Console.WriteLine();

            // Part #2
            Console.WriteLine("Part 2 of Exercise:");

           static double AreaOfCircle(double r)
            {
                double pi = 3.14159;
                double area = pi * (r * r);
                return area;
            }

            Console.WriteLine("What is the radius of the circle?");
            var radius = double.Parse(Console.ReadLine());

            double result = AreaOfCircle(radius);

            Console.WriteLine($"The area of the circle with radius of {radius} is {result}.");
            Console.WriteLine();

            // Thought exercise
            Console.WriteLine("Thought Exercise - for fun");
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine("In this scenario, 3 is incremented and then used.");
            Console.WriteLine($"Then 4 is used, then incremented.");
            Console.WriteLine($"Thus, 3 becomes 4 and multiplies 4");
            Console.WriteLine($"The result is {k}.");

        }
    }
}
