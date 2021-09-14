using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoseBall.Data
{
    public class FoseBallDbContext : DbContext
    {
        //Constructor with DbContext base
        public FoseBallDbContext() : base("DefaultConnection") { }

        public DbSet<Player> Players { get; set; }
        public DbSet<League> Leagues { get; set; }
    }
}
