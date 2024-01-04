using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Sistema_CRUD.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Client> Clientes { get; set; }
    }   
}
