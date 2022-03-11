using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_tasks.Models
{
    public class ApplicationDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\Glavi\source\repos\desktop-tasks\DB\TaskListDB.db")
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Goal> Goals { get; set; }
    }
}
