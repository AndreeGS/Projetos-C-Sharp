using Microsoft.EntityFrameworkCore;
using Challenge_Back_End.Model;

namespace Challenge_Back_End.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<PlanetaModel> Planetas { get; set; }
    }
}
