using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAnnotations2
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions<DbContext> options) : base(options) { }
        public DbSet<Data> Data { get; set; }
    }
}
