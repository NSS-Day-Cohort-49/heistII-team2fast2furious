using System;

namespace HeistPartII
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank b)
        {
            b.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name} is cracking the vault code. Decreased security {SkillLevel} points");
            if (b.VaultScore <= 0){
                Console.WriteLine($"{Name} has opened the vault!");
            }
        }
    }
}