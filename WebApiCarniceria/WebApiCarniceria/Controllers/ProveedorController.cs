using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApiCarniceria.Controllers.Entidades;

namespace WebApiCarniceria.Controllers
{
    [ApiController]
    [Route("api/Proveedor")]
    public class ProveedorController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public ProveedorController(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        [HttpGet]
        public ActionResult<List<Proveedor>> Get()
        {
            return new List<Proveedor>()
            {
                new Proveedor { Id = 1,
                    CarniceriaId = 1,
                    Name = "Carnes Mauricio",
                    Contact = "+52 8812201458",
                    Address = "Avenida Universidad 1250 nte, Villarreal, 66447 San Nicolás de los Garza, N.L."},

                new Proveedor { Id = 2,
                    CarniceriaId = 1,
                    Name = "Carnes José Luis",
                    Contact = "jose_luis@carnes.com",
                    Address = "Av. Sendero Divisorio 1502, Privadas de Anáhuac, 66059 Cd Gral Escobedo, N.L."}
            };
        }

        [HttpPost]
        public async Task<ActionResult> Post(Proveedor proveedor)
        {
            dbContext.Add(proveedor);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("/ListaProveedor")]
        public async Task<ActionResult<List<Proveedor>>> GetAll()
        {
            return await dbContext.Proveedor.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Proveedor>> GetById(int id)
        {
            return await dbContext.Proveedor.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Proveedor proveedor, int id)
        {
            if (proveedor.Id != id)
            {
                return BadRequest("El id del proveedor no coincide con el establecido en la url.");
            }

            dbContext.Update(proveedor);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Proveedor.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound("No se encontro el registro en la base de datos.");
            }

            dbContext.Remove(new Proveedor()
            {
                Id = id
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
