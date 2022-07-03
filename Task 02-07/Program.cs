using System;

namespace Task_02_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var attemps = 10;
            string password;
            
            while (true)
            {
                Console.Write("Enter your password: ");
                password = Console.ReadLine();

                if (password.Length >= 9 &&
                    password[password.Length - 1] == '=' &&
                    Char.IsUpper(password[0]))
                {
                    Console.WriteLine("Success");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid password");
                    attemps--;
                    if (attemps == 0)
                    {
                        Console.WriteLine("You are not allowed to create and account");
                        return;
                    }
                }
            }
        }
    }
}
