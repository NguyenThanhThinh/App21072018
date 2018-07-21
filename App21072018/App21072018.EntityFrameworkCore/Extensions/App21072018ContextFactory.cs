using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace App21072018.EntityFrameworkCore.Extensions
{
    public class App21072018DbContextFactory : IDesignTimeDbContextFactory<App21072018DbContext>
    {
        public App21072018DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<App21072018DbContext>();

            builder.UseSqlServer("Server=.\\SQLEXPRESS;Database=App21072018DbContext;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new App21072018DbContext(builder.Options);
        }
    }
}
