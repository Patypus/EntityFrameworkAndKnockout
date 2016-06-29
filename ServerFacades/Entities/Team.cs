using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class Team
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ColourFlash { get; set; }

        public virtual ICollection<TeamChampionshipEntry> ChapionshipEntries { get; set; }
    }
}
