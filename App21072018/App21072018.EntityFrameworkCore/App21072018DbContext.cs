namespace App21072018.EntityFrameworkCore
{
    using App21072018.Core.Domains;
    using App21072018.EntityFrameworkCore.Mapping;
    using Microsoft.EntityFrameworkCore;

    public class App21072018DbContext : DbContext
    {
        public App21072018DbContext(DbContextOptions<App21072018DbContext> options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder )
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
        }
    }
}
