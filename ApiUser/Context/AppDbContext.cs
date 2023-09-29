using Microsoft.EntityFrameworkCore;
using projeto.ApiUser.Models;


namespace projeto.ApiUser.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base( options ) { }
        public DbSet<Users>? Users { get; set; }
    }
}