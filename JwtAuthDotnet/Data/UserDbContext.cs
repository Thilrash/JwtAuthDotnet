using JwtAuthDotnet.Entities;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthDotnet.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
