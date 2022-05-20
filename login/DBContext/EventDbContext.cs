using login.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login.DBContext
{
    public class EventDbContext: DbContext
    {
            public EventDbContext()
            {
            }

            public EventDbContext(DbContextOptions<EventDbContext> options)
                : base(options)
            {
            }

           // public virtual DbSet<TblEvent> TblEvents { get; set; }
            public virtual DbSet<Users> TblUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Users>().ToTable("Users");

        }

        
        }
}
