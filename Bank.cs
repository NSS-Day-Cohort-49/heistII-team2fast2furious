using System;

namespace HeistPartII
{

    public class Bank
    {
        public int AlarmScore { get; set; }
        public int CashOnHand { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }

        public bool isSecure
        {
            get
            {
                if (AlarmScore <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public Bank()
        {
            AlarmScore = new Random().Next(0, 101);
            CashOnHand = new Random().Next(50000, 1000001);
            VaultScore = new Random().Next(0, 101);
            SecurityGuardScore = new Random().Next(0, 101);

        }


        public void Recon()
        {
            if (AlarmScore > VaultScore && AlarmScore > SecurityGuardScore)
            {
                Console.WriteLine("Most secure alarm");
            }
            else if (VaultScore > AlarmScore && VaultScore > SecurityGuardScore)
            {
                Console.WriteLine("Most secure vault");
            }
            else if (SecurityGuardScore > AlarmScore && SecurityGuardScore > VaultScore)
            {
                Console.WriteLine("Most secure security guard");
            }
            if (AlarmScore < VaultScore && AlarmScore < SecurityGuardScore)
            {
                Console.WriteLine("Least secure alarm");
            }
            else if (VaultScore < AlarmScore && VaultScore < SecurityGuardScore)
            {
                Console.WriteLine("Least secure vault");
            }
            else if (SecurityGuardScore < AlarmScore && SecurityGuardScore < VaultScore)
            {
                Console.WriteLine("least secure security guard");
            }
        }

    }
}