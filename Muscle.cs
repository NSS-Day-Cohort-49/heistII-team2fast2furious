using System;

namespace HeistPartII
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank b)
        {
            b.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name} is beating up the guards. Decreased security {SkillLevel} points");
            if (b.SecurityGuardScore <= 0){
                Console.WriteLine($"{Name} has taken care of all guards!");
            }
        }
    }
}