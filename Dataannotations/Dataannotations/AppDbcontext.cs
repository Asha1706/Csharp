using Dataannotations.Models;
using Microsoft.EntityFrameworkCore;

namespace Dataannotations
{
    public class AppDbcontext : DbContext 
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options) { }
        public DbSet<Data> Data { get; set; }
    }
}
