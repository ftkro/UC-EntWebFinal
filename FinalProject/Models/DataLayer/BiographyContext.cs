using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class BiographyContext : DbContext
    {
        public BiographyContext(DbContextOptions<BiographyContext> options)
            : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new HobbyConfig());
            modelBuilder.ApplyConfiguration(new PersonConfig());
        }

    }
}
