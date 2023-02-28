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
                new Carniceria { Id = 1, Name = "Ramos"},
                new Carniceria { Id = 2, Name = "San Carlos"}
            };
        }
    }
}
