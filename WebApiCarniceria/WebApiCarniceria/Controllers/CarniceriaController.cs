using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApiCarniceria.Controllers.Entidades;

namespace WebApiCarniceria.Controllers
{
    [ApiController]
    [Route("api/Carniceria")]
    public class CarniceriaController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public CarniceriaController(ApplicationDbContext context) 
        {
            this.dbContext = context;
        }

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

        [HttpPost]
        public async Task<ActionResult> Post(Carniceria carniceria)
        {
            dbContext.Add(carniceria);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("/Lista")]
        public async Task<ActionResult<List<Carniceria>>> GetAll()
        {
            return await dbContext.Carniceria.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Carniceria>> GetById(int id)
        {
            return await dbContext.Carniceria.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Carniceria carniceria, int id)
        {
            if (carniceria.Id != id)
            {
                return BadRequest("El id de la carniceria no coincide con el establecido en la url.");
            }

            dbContext.Update(carniceria);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Carniceria.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound("No se encontro el registro en la base de datos.");
            }

            dbContext.Remove(new Carniceria()
            {
                Id = id
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
