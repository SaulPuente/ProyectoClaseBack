using Microsoft.EntityFrameworkCore;
using WebApiCarniceria.Controllers.Entidades;

namespace WebApiCarniceria
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options)  : base(options) 
        {
            
        }

        public DbSet<Carniceria> Carniceria { get; set; }
    }
}
