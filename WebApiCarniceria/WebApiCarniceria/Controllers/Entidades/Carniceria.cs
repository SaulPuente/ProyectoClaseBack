using Microsoft.Extensions.Hosting;

namespace WebApiCarniceria.Controllers.Entidades
{
    public class Carniceria
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Schedule { get; set; }
        public string Phone { get; set; }
        public List<Proveedor> Proveedores { get; set; }
    }
}
