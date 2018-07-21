using Microsoft.EntityFrameworkCore;

namespace App21072018.EntityFrameworkCore.Mapping
{
    using App21072018.Core.Domains;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(n => n.Id);
        }
    }
}
