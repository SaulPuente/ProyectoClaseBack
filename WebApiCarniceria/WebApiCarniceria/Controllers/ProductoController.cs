using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApiCarniceria.Controllers.Entidades;

namespace WebApiCarniceria.Controllers
{
    [ApiController]
    [Route("api/Producto")]
    public class ProductoController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public ProductoController(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        [HttpGet]
        public ActionResult<List<Producto>> Get()
        {
            return new List<Producto>()
        {
            new Producto { Id = 1,
                Name = "Costilla",
                Quantity = 7,
                Price = 95.87,
                Cost = 45.22},

            new Producto { Id = 2,
                Name = "Filete",
                Quantity = 12,
                Price = 145.23,
                Cost = 85.99}
        };
        }

        [HttpPost]
        public async Task<ActionResult> Post(Producto producto)
        {
            dbContext.Add(producto);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("/ListaProducto")]
        public async Task<ActionResult<List<Producto>>> GetAll()
        {
            return await dbContext.Producto.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Producto>> GetById(int id)
        {
            return await dbContext.Producto.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Producto producto, int id)
        {
            if (producto.Id != id)
            {
                return BadRequest("El id del producto no coincide con el establecido en la url.");
            }

            dbContext.Update(producto);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Producto.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound("No se encontro el registro en la base de datos.");
            }

            dbContext.Remove(new Producto()
            {
                Id = id
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
