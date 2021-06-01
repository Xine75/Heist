using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.Write("Choose a conspirator...\n>");
            string conspirator = Console.ReadLine();


            List<Conspirator> Team = new List<Conspirator>();
            MakeYourTeam();
            void MakeYourTeam()
            {
                if (conspirator == "")
                {

                    Console.WriteLine("Your team is complete!");
                    int teamCount = Team.Count;
                    Console.WriteLine($"Your team has {teamCount} criminal masterminds.");
                    foreach (Conspirator criminal in Team)
                    {
                        Console.WriteLine($"{criminal.Name} has a Skill Level of {criminal.SkillLevel} and courage level of {criminal.CourageFactor}.");
                    }
                    return;
                }
                else
                {


                    Console.WriteLine($"You have chosen {conspirator}");

                    Console.Write($"On a scale of 1 - 10, what is {conspirator}'s Skill Level?\n>");
                    int skill = Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"{conspirator}'s skill level is {skill}.  Very good.");

                    Console.Write($"From 0.0 to 2.0 , what is {conspirator}'s Courage Factor?\n>");
                    double courage = Double.Parse(Console.ReadLine());
                    Console.WriteLine($"{conspirator}'s SKILL LEVEL is {skill} and COURAGE FACTOR IS {courage}.  You have chosen well.");

                    Conspirator criminal = new Conspirator(conspirator, skill, courage);
                    Team.Add(criminal);
                    Console.WriteLine("Choose your next teammate \n>");
                    conspirator = Console.ReadLine();
                    MakeYourTeam();
                }
            }
        }
    }
}

