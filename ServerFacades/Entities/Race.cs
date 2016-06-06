using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class Race
    {
        [Key]
        public Guid RaceId { get; set; }

        public int YearNumber { get; set; }

        public string RaceName { get; set; }

        public DateTime RaceDate { get; set; }

        public ICollection<RaceResultPosition> Results { get; set; }
    }
}
