using System;

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
