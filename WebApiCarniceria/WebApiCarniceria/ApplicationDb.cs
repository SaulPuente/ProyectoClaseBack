using Microsoft.EntityFrameworkCore;
using WebApiCarniceria.Controllers.Entidades;

namespace WebApiCarniceria
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)  : base(options) 
        {
            
        }

        public DbSet<Carniceria> Carniceria { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Proveedor> Proveedor { get; set;}
    }
}
