using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class Team
    {
        [Key]
        public Guid TeamId { get; set; }

        public String TeamName { get; set; }

        public int RacesEntered { get; set; }

        public List<int> ChampionshipYears { get; set; }
    }
}
