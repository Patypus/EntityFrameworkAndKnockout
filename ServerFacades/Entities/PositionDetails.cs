﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class PositionDetails
    {
        [Key]
        public Guid Id { get; set; }

        public int PosiitionNumber { get; set; }

        public int Points { get; set; }

        public virtual ICollection<RaceResultPosition> RaceResultPositions { get; set; }
    }
}
