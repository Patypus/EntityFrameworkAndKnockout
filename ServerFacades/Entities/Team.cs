using System;
using System.Collections.Generic;
namespace ServerFacades.Entities
{
    public class Team
    {
        public int TeamId { get; set; }

        public String TeamName { get; set; }

        public int RacesEntered { get; set; }

        public List<int> ChampionshipYears { get; set; }
    }
}
