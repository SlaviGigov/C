using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your team name: ");
            var MyTeam = Console.ReadLine();
            var MyPoints = 0;
            var Teams = 0;
            var MyPlace = 1;
            var result = "";
            var Enemy = "";
            var Play = true;

            while (Play)
            {
                Console.Write("Event: ");
                var Event = Console.ReadLine();

                switch (Event)
                {
                    case ("Match"):
                        Teams++;
                        Console.Write("Against: ");
                        Enemy = Console.ReadLine();
                        Console.Write("Host of Guest: ");
                        var Where = Console.ReadLine();
                        Console.WriteLine("Result: ");
                        Console.Write("Host Goals: ");
                        var HostGoals = int.Parse(Console.ReadLine());
                        Console.Write("Guest Goals: ");
                        var GuestGoals = int.Parse(Console.ReadLine());

                        if (HostGoals == GuestGoals)
                        {
                            result = "Draw";
                            MyPoints++;
                        }
                        else if ((Where == "host" && HostGoals > GuestGoals) || (Where == "guest" && GuestGoals > HostGoals))
                        {
                            result = "Win";
                            MyPoints += 3;
                        }
                        else result = "Lose";
                        ; break;

                    case ("Disqualification"):
                        Console.Write("Team: ");
                        var Disquialified = Console.ReadLine();
                        if ((Disquialified == Enemy) && (result == "Lose"))
                            MyPoints += 3;
                        else if ((Disquialified == Enemy) && (result == "Draw"))
                            MyPoints += 2;
                        ; break;

                    case ("EndOfTheSeason"): Console.WriteLine("Season ended!"); Play = false; break;
                    default: Console.WriteLine("Wrong event.Try Again!"); break;
                }
            }

            for (int i = 0; i < Teams; i++)
            {
                Console.Write("Team: ");
                Console.ReadLine();
                Console.Write("Points: ");
                var points = int.Parse(Console.ReadLine());

                if (points > MyPoints) MyPlace++;
            }
          
        Console.WriteLine($"Total points: {MyPoints}");
        Console.WriteLine($"{MyTeam} finished at {MyPlace} place this season ");
        }
    }
}
