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
        }
    }
}
