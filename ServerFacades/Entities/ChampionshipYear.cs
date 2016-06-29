using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class ChampionshipYear
    {
        [Key]
        public Guid Id { get; set; }

        public int Year { get; set; }

        public virtual ICollection<Race> Races { get; set; }

        public virtual ICollection<TeamChampionshipEntry> TeamChampionshipEntrys { get; set; }
    }
}
