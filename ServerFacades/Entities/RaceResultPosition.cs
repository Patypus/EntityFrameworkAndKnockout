using System;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class RaceResultPosition
    {
        [Key]
        public Guid Id { get; set; }
        
        public Guid RaceId { get; set; }

        public virtual Race Race { get; set; }

        public Guid DriverId { get; set; }

        public virtual Driver Driver { get; set; }

        public Guid PositionDetailsId { get; set; }

        public virtual PositionDetails PosiitonDetails { get; set; }
    }
}
