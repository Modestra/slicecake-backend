using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Note.Domain;

namespace Slice.Persistance;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    public DbSet<Notes> Note { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<ShortUserDto> ShortUser { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShortUserDto>(builder =>
        {
            builder.HasNoKey();
            builder.ToTable("ShortUsers");
        });
        modelBuilder.Entity<User>(builder =>
        {
            builder.ToTable("Users").HasKey(id => id.id);
        });
    }
}