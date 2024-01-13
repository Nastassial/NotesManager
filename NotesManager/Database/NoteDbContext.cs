using Microsoft.EntityFrameworkCore;
using NotesManager.Entities;

namespace NotesManager.Database;

public class NoteDbContext : DbContext
{
    public DbSet<Note> Notes { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Tab> Tabs { get; set; }

    public DbSet<Contact> Contacts { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<UserProfile> UserProfiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // вынос в файл конфигурации appsettings.json
        //var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").SetBasePath(Directory.GetCurrentDirectory()).Build();
        //optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NotesManagerDb;Trusted_Connection=True;");

        optionsBuilder.LogTo(Console.WriteLine);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // использование Fluent API
        //modelBuilder.ApplyConfiguration(new CategoryEntityTypeConfiguration());
    }
}
