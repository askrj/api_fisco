using Microsoft.EntityFrameworkCore;
using projeto.Api_fisco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.Api_fisco.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base( options ) { }
        public DbSet<Users>? Users { get; set; }
    }
}