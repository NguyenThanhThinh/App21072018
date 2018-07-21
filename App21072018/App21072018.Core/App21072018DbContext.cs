using System;
using System.Collections.Generic;
using System.Text;

namespace App21072018.Core
{
    using Microsoft.EntityFrameworkCore;
    
    public class App21072018DbContext : DbContext
    {
        public App21072018DbContext(DbContextOptions<App21072018DbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder )
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new CategoryMap());
        }
    }
}
