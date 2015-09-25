using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class Race
    {
        [Key]
        public Guid RaceId { get; set; }

        public string RaceName { get; set; }

        public DateTime RaceDate { get; set; }

        public IEnumerable<RaceResultPosition> Results { get; set; }
    }
}
