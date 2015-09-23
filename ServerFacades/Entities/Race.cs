using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFacades.Entities
{
    public class Race
    {
        public Guid RaceId { get; set; }

        public string RaceName { get; set; }

        public DateTime RaceDate { get; set; }

        public IEnumerable<RaceResultPosition> Results { get; set; }
    }
}
