using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotesManager.Entities;

namespace NotesManager.Database;

public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        // использование Fluent API
        builder.HasIndex(c => new { c.ParentId, c.UserId })
               .HasFilter("[ParentId] IS NOT NULL")
               .HasFilter("[UserId] IS NOT NULL");

        builder.Property(c => c.Name)
               .HasMaxLength(100)
               .IsRequired();
    }
}
