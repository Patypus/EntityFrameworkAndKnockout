using System;
using System.ComponentModel.DataAnnotations;

namespace ServerFacades.Entities
{
    public class DriverChampionshipEntry
    {
        [Key]
        public Guid Id { get; set; }

        public Guid TeamChampionshipEntryId { get; set; }

        public Guid DriverId { get; set; }

        public virtual TeamChampionshipEntry TeamChampionshipEntry { get; set; }

        public virtual Driver Driver { get; set; }
    }
}
