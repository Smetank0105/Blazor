using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Academy_2.Components.Models;

namespace Academy_2.Data
{
    public class Academy_2Context : DbContext
    {
        public Academy_2Context (DbContextOptions<Academy_2Context> options)
            : base(options)
        {
        }

        public DbSet<Academy_2.Components.Models.Direction> Directions { get; set; } = default!;
        public DbSet<Academy_2.Components.Models.Group> Groups { get; set; } = default!;
        
    }
}
