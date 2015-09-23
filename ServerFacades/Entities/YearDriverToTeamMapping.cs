using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFacades.Entities
{
    public class YearDriverToTeamMapping
    {
        public int YearNumber { get; set; }

        public int TeamId { get; set; }

        public IEnumerable<int> DriverIds { get; set; }
    }
}
