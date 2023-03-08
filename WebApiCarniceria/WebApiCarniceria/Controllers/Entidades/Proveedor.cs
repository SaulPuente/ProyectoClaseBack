using System.Reflection.Metadata;

namespace WebApiCarniceria.Controllers.Entidades
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public int CarniceriaId { get; set; }
        public Carniceria Carniceria { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}
