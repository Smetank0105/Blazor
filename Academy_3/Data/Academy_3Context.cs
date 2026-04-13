using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Academy_3.Components.Models;

namespace Academy_3.Data
{
    public class Academy_3Context : DbContext
    {
        public Academy_3Context (DbContextOptions<Academy_3Context> options)
            : base(options)
        {
        }

        public DbSet<Academy_3.Components.Models.Direction> Directions { get; set; } = default!;
        public DbSet<Academy_3.Components.Models.Group> Groups { get; set; } = default!;
        public DbSet<Academy_3.Components.Models.Student> Students { get; set; } = default!;
        public DbSet<Academy_3.Components.Models.Teacher> Teachers { get; set; } = default!;
        public DbSet<Academy_3.Components.Models.Discipline> Disciplines { get; set; } = default!;
        public DbSet<Academy_3.Components.Models.TeacherDisciplineRelation> TeachersDisciplinesRelation { get; set; } = default!;
    }
}
