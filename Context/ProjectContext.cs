using Microsoft.EntityFrameworkCore;
using NetCoreUnityIOC.Models.Entities;

namespace NetCoreUnityIOC.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers  { get; set; }
    }
}
