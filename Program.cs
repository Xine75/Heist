using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.Write("Choose a conspirator...\n>");
            string conspirator = Console.ReadLine();
            if (conspirator == "")
            {
                Console.WriteLine("Your team is complete!");
                return;
            }
            else
            {

                Console.WriteLine($"You have chosen {conspirator}");

                Console.Write($"On a scale of 1 - 10, what is {conspirator}'s Skill Level?\n>");
                string skill = Console.ReadLine();
                Console.WriteLine($"{conspirator}'s skill level is {skill}.  Very good.");

                Console.Write($"From 0.0 to 2.0 , what is {conspirator}'s Courage Factor?\n>");
                string courage = Console.ReadLine();
                Console.WriteLine($"{conspirator}'s SKILL LEVEL is {skill} and COURAGE FACTOR IS {courage}.  You have chosen well.");

            }
            continue;
        }
    }
}

