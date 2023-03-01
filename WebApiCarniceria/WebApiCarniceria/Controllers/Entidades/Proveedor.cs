namespace WebApiCarniceria.Controllers.Entidades
{
    public class Proveedor
    {
        public int Id { get; set; }
        public int Carniceria { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
    }
}
