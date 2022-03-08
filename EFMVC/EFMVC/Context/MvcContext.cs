using EFMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EFMVC.Context
{
    public class MvcContext : DbContext
    {
        public MvcContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
