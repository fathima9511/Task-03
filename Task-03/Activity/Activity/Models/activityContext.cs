
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity.Models
{
    public class activityContext : DbContext
    {
        public activityContext(DbContextOptions<activityContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<activity> Activity { get; set; }



    }
}
