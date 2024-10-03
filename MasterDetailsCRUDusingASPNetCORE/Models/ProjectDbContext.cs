using Microsoft.EntityFrameworkCore;

namespace MasterDetailsCRUDusingASPNetCORE.Models
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext()
        {
            
        }
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options):base(options)
        {
            
        }
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Experience> Experiences { get; set; }
    }
}
