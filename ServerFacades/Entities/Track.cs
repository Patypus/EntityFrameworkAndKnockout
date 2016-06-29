using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class Track
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int LapLengthMeters { get; set; }

        public virtual ICollection<Race> Races { get; set; }
    }
}
