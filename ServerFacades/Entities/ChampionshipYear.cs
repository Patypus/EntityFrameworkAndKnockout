using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFacades.Entities
{
    public class ChampionshipYear
    {
        public int YearNumber { get; set; }
        
        public IEnumerable<YearDriverToTeamMapping> DriverToTeamMappings { get; set; }
        
        public IEnumerable<Race> Races { get; set; } 
    }
}
