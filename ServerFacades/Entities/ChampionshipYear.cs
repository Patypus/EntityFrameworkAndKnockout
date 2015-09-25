using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class ChampionshipYear
    {
        [Key]
        public int YearNumber { get; set; }
        
        public IEnumerable<YearDriverToTeamMapping> DriverToTeamMappings { get; set; }
        
        public IEnumerable<Race> Races { get; set; } 
    }
}
