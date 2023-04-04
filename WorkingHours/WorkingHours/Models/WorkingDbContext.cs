using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Data.Entity;

namespace WorkingHours.Models
{
    public class WorkingDbContext : DbContext
    {
        public WorkingDbContext(DbContextOptions<WorkingDbContext>options) :base(options)
            { }
    }
    public DbSet<Working> Working{ get; set; }
}
