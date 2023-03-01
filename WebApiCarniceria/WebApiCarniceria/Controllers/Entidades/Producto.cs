namespace WebApiCarniceria.Controllers.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public int Supplier { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }
    }
}
