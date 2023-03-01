using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiCarniceria.Controllers.Entidades;

namespace WebApiCarniceria.Controllers
{
    [ApiController]
    [Route("api/Carniceria")]
    public class CarniceriaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Carniceria>> Get()
        {
            return new List<Carniceria>()
            {
                new Carniceria { Id = 1, 
                    Name = "Ramos", 
                    Address = "Av. Santo Domingo 1420, Valle de Santo Domingo, 66431 San Nicolás de los Garza, N.L.", 
                    Schedule = "Lunes a Viernes: 08:00 a.m - 10:00 p.m.", 
                    Phone = "0123456789"},

                new Carniceria { Id = 2, 
                    Name = "San Carlos", 
                    Address = "Carr. Apodaca - Sta. Rosa 401, Rinconada Colonial de Apodaca, 66606 Cd Apodaca, N.L.", 
                    Schedule = "Lunes a Viernes: 10:00 a.m - 06:00 p.m.; Sábado: 10:00 a.m. - 04:00 p.m.", 
                    Phone = "1234567890"}
            };
        }
    }
}
