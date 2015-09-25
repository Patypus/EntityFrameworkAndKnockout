using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class YearDriverToTeamMapping
    {
        [Key]
        public int YearNumber { get; set; }

        [Key]
        public int TeamId { get; set; }

        public IEnumerable<int> DriverIds { get; set; }
    }
}
