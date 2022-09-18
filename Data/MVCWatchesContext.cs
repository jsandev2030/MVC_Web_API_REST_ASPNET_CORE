using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCWatches.Models;

namespace MVCWatches.Data
{
    public class MVCWatchesContext : DbContext
    {
        public MVCWatchesContext (DbContextOptions<MVCWatchesContext> options)
            : base(options)
        {
        }

        public DbSet<MVCWatches.Models.Watches> Watches { get; set; } = default!;
    }
}
