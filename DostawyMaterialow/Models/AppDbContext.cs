using Microsoft.EntityFrameworkCore;

namespace DostawyMaterialow.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Dostawa> Dostawy { get; set; }
    }
}
