using ServerFacades.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerFacades.Context
{
    public class Context : DbContext
    {
        public DbSet<Driver> Drivers { get; set; }
    }
}
