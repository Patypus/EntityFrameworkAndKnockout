using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFacades.Entities
{
    public class RaceResultPosition
    {
        public Guid Id { get; set; }

        public Guid RaceId { get; set; }

        public int Position { get; set; }

        public int DriverId { get; set; }
    }
}
