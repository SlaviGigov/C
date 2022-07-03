using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = 0.0;
            var count = 0;
            Console.Write("Input: ");
            var input = Console.ReadLine();

            while (input != "end")
            {
                var grade = double.Parse(input);
                if (2 <= grade && grade <= 6)
                {
                    sum = +grade;
                    count++;
                    Console.Write("Input: ");
                    input = Console.ReadLine();
                }
            }

            Console.WriteLine($"Average grade is {Math.Round((sum / count), 2)}");
        }
    }
}
