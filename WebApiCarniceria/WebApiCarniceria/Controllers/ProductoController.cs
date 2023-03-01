using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiCarniceria.Controllers.Entidades;

namespace WebApiCarniceria.Controllers
{
    [ApiController]
    [Route("api/Producto")]
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Producto>> Get()
        {
            return new List<Producto>()
        {
            new Producto { Id = 1,
                Supplier = 1,
                Name = "Costilla",
                Quantity = 7,
                Price = 95.87,
                Cost = 45.22},

            new Producto { Id = 2,
                Supplier = 1,
                Name = "Filete",
                Quantity = 12,
                Price = 145.23,
                Cost = 85.99}
        };
        }
    }
}
