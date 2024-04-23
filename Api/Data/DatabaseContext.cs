using Microsoft.EntityFrameworkCore;
using Models;

namespace Api.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<AuthenticationData> Authentications { get; set; }
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
    }
}
