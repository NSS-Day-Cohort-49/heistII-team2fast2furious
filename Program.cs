using System;
using System.Collections.Generic;

namespace HeistPartII
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Rolodex team and starting members
            Team Rolodex = new Team();
            Hacker John = new Hacker() { Name = "John", SkillLevel = 50, PercentageCut = 20 };
            Hacker Billy = new Hacker() { Name = "Billy", SkillLevel = 40, PercentageCut = 15 };
            LockSpecialist Kyle = new LockSpecialist() { Name = "Kyle", SkillLevel = 45, PercentageCut = 15 };
            LockSpecialist Carmen = new LockSpecialist() { Name = "Carmen", SkillLevel = 40, PercentageCut = 20 };
            Muscle Chad = new Muscle() { Name = "Chad", SkillLevel = 50, PercentageCut = 25 };
            Muscle Brad = new Muscle() { Name = "Brad", SkillLevel = 45, PercentageCut = 20 };
            Rolodex.Robbers.Add(John);
            Rolodex.Robbers.Add(Billy);
            Rolodex.Robbers.Add(Kyle);
            Rolodex.Robbers.Add(Carmen);
            Rolodex.Robbers.Add(Chad);
            Rolodex.Robbers.Add(Brad);

            //Prompt user to create new robbers of any class until they do not enter a name
            while (true)
            {
                Console.WriteLine($"There are {Rolodex.Robbers.Count} robbers in your rolodex");
                Console.WriteLine("Enter a potential crew member's name: ");
                string robberName = Console.ReadLine();
                if (robberName == "")
                {
                    break;
                }
                Console.WriteLine($"Please pick a speciality for {robberName}: \n 1) Hacker \n 2) LockSpecialist \n 3) Muscle");
                int specialtyIndex = int.Parse(Console.ReadLine());
                Console.WriteLine($"Please enter {robberName}'s skill level (1-100) :");
                int robberSkill = int.Parse(Console.ReadLine());
                Console.WriteLine($"Please enter {robberName}'s desired cut percentage (1-100) : ");
                int robberCut = int.Parse(Console.ReadLine());
                switch (specialtyIndex)
                {

                    case 1:
                        Hacker hacker = new Hacker() { Name = robberName, SkillLevel = robberSkill, PercentageCut = robberCut };
                        Rolodex.Robbers.Add(hacker);
                        break;

                    case 2:
                        LockSpecialist lockSpecialist = new LockSpecialist() { Name = robberName, SkillLevel = robberSkill, PercentageCut = robberCut };
                        Rolodex.Robbers.Add(lockSpecialist);
                        break;

                    case 3:
                        Muscle muscle = new Muscle() { Name = robberName, SkillLevel = robberSkill, PercentageCut = robberCut };
                        Rolodex.Robbers.Add(muscle);
                        break;

                    default:
                        break;
                }

            }
            Bank bank = new Bank();
            bank.Recon();
        }
    }
}
