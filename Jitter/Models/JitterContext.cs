using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Jitter.Models
{
    public class JitterContext : DbContext    
    {
        // IDbSet, IQueryable (Other options that developers may use in replace of DbSet)
        public DbSet<JitterUser> JitterUsers { get; set; } // creates a jitter user table. 
        public DbSet<Jot> Jots { get; set; }
    }
}