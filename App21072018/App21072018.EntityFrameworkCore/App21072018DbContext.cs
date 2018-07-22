namespace App21072018.EntityFrameworkCore
{
    using App21072018.Core;
    using App21072018.Core.Domains;
    using App21072018.EntityFrameworkCore.Mapping;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class App21072018DbContext : DbContext, IUnitOfWork
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

        public async Task CommitAsync()
        {
            await base.SaveChangesAsync();
        }

        public void Commit()
        {
            base.SaveChanges();
        }
    }
}
