using System.Collections.Generic;

namespace HeistPartII
{
    public class Team 
    {
        public List<IRobber> Robbers { get; set; }
        public Team() {
            Robbers = new List<IRobber>();
        }
    }
}