using Microsoft.EntityFrameworkCore;
using TimelyApp.Model;

namespace TimelyApp.Repository
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.UseSerialColumns();
        }
        
        public DbSet<Project> Projects { get; set; }
    }
}
