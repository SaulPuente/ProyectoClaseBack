using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiCarniceria.Controllers.Entidades;

namespace WebApiCarniceria.Controllers
{
    [ApiController]
    [Route("api/Proveedor")]
    public class ProveedorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Proveedor>> Get()
        {
            return new List<Proveedor>()
            {
                new Proveedor { Id = 1,
                    Carniceria = 1,
                    Name = "Carnes Mauricio",
                    Contact = "+52 8812201458",
                    Address = "Avenida Universidad 1250 nte, Villarreal, 66447 San Nicolás de los Garza, N.L."},

                new Proveedor { Id = 2,
                    Carniceria = 1,
                    Name = "Carnes José Luis",
                    Contact = "jose_luis@carnes.com",
                    Address = "Av. Sendero Divisorio 1502, Privadas de Anáhuac, 66059 Cd Gral Escobedo, N.L."}
            };
        }
    }
}
