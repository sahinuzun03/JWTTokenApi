using ApıJwt.Models;
using Microsoft.EntityFrameworkCore;

namespace ApıJwt.Context
{
    public class JwtTestDbContext : DbContext
    {
        public JwtTestDbContext(DbContextOptions<JwtTestDbContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
