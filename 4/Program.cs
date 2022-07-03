using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your budget: ");
            var budget = double.Parse(Console.ReadLine());
            var initialBudget = budget;
            double spent = 0.0;

            while (true)
            {
                Console.Write("Enter your command: ");
                var task = Console.ReadLine();

                switch (task)
                {
                    case ("buy"): 
                        Console.Write("Product name: ");
                        var name = Console.ReadLine();
                        Console.Write("Product quantity: ");
                        var quantity = double.Parse(Console.ReadLine());
                        Console.Write("Product price: ");
                        var price = double.Parse(Console.ReadLine());

                        if (budget <= (price * quantity))
                            Console.WriteLine("You can not afford this");
                        else
                        {
                            budget -= price * quantity;
                            spent += price * quantity;
                        }

                        if (initialBudget * 0.1 <= budget)
                            Console.WriteLine("You will run out of money soon.");
                        break;
                    case ("info"): Console.WriteLine($"You spent {Math.Round(spent, 2)}, you have {Math.Round(budget, 2)} left"); ; break;
                    case ("exit"): Console.WriteLine($"You spent {Math.Round(spent, 2)}, you have {Math.Round(budget, 2)} left"); return;
                }
            }
        }
    }
}
