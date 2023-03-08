using System.Reflection.Metadata;

namespace WebApiCarniceria.Controllers.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}
