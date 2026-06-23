using Microsoft.EntityFrameworkCore;
using MyRecipeBook.Domain;

namespace MyRecipeBook.Infrastructure;

internal class MyRecipeBookDbContext : DbContext
{
  public MyRecipeBookDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

  public DbSet<User> Users { get; set; }
}
