using AquaWorld.Models;
using Microsoft.EntityFrameworkCore;

namespace AquaWorld.Data
{
    public class AquaDbContext:DbContext
    {
        public AquaDbContext(DbContextOptions<AquaDbContext> options) : base(options)
        {
        }


        public DbSet<Aqua> Aquas { get; set; }
    }
}
