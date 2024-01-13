using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotesManager.Entities;

namespace NotesManager.Database;

public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasIndex(c => c.ParentId)
               .HasFilter("[ParentId] IS NOT NULL");

        builder.Property(c => c.Name)
               .HasMaxLength(100)
               .IsRequired();
    }
}
