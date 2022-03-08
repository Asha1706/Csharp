using Microsoft.EntityFrameworkCore;
using Models;

namespace CRUDOperations
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Contact> Contact { get; set; }
    }
}
