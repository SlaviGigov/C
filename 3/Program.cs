using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            var word = Console.ReadLine();
            var match = true;

            for (int i = 0; i < word.Length-1; i++)
            {
                var first = word[i];
                var second = word[i + 1];
                if (first == second)
                {
                    Console.WriteLine($"Match: {first} in indexes {i} and {i + 1}");
                    match = false;
                }
            }
                if (match)
                Console.WriteLine("No Match");
            
        }
    }
}
