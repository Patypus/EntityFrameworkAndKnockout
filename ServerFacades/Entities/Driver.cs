using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class Driver
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public bool Retired { get; set; }

        public virtual ICollection<DriverChampionshipEntry> DriverChampionshipEntries { get; set; }

        public virtual ICollection<RaceResultPosition> RaceResultPositions { get; set; }
    }
}
