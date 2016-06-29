﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class TeamChampionshipEntry
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ChampionshipYerId { get; set; }

        public Guid TeamId { get; set; }

        public virtual ChampionshipYear ChampionshipYear { get; set; }

        public virtual Team Team { get; set; }

        public virtual ICollection<DriverChampionshipEntry> DriverChampionshipEntries { get; set; }
    }
}
