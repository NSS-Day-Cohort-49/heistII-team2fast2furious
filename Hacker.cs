using System;

namespace HeistPartII
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill(Bank b)
        {
            b.AlarmScore -= SkillLevel
        }
    }
}