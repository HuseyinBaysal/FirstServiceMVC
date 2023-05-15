using FirstServiceMVC.Infrastructure.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FirstServiceMVC.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }
}

