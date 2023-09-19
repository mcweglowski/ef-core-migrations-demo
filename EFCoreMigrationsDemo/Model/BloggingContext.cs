using Microsoft.EntityFrameworkCore;

namespace EFCoreMigrationsDemo.Model;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
}