using System.Collections.Generic;

namespace ServerFacades.Entities
{
    public class ChampionshipYear
    {
        public int YearNumber { get; set; }
        
        public IEnumerable<YearDriverToTeamMapping> DriverToTeamMappings { get; set; }
        
        public IEnumerable<Race> Races { get; set; } 
    }
}
