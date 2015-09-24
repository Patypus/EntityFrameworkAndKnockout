using System.Collections.Generic;

namespace ServerFacades.Entities
{
    public class YearDriverToTeamMapping
    {
        public int YearNumber { get; set; }

        public int TeamId { get; set; }

        public IEnumerable<int> DriverIds { get; set; }
    }
}
