using ServerFacades.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFacades.Database
{
    public class Context : DbContext
    {
        public DbSet<ChampionshipYear> ChampionshipYears{ get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverChampionshipEntry> DriverChampionshipEntry { get; set; }
        public DbSet<PositionDetails> PositionDetails { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<RaceResultPosition> RaceResultPositions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamChampionshipEntry> TeamChampionshipEntrys { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}
