using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }

        public string Name { get; set; }

        public int RacesEntered { get; set; }

        public int NumberOfPodiums { get; set; }

        public int NumberOfWins { get; set; }

        public virtual ICollection<RaceResultPosition> RaceResultPossitions { get; set; }
    }
}
