using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part #1

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


        }
    }
}
