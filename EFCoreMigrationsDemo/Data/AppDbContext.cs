using EFCoreMigrationsDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMigrationsDemo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
}