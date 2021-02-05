using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Login_CRUD.Context;
using API_Login_CRUD.Models;

namespace API_Login_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly BDProductosContext _context;

        public ProductosController(BDProductosContext context)
        {
            _context = context;
        }

        // GET: api/Productos
        [HttpGet]
        public ActionResult Getproductos()
        {
            try
            {
                return Ok(_context.productos.ToList());
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Productos/5
        [HttpGet("{id}",Name = "GetProducto")]
        public ActionResult GetProductos(int id)
        {
            try
            {
                var productos = _context.productos.FirstOrDefault(p => p.id_prod == id);
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Productos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult PostProductos([FromBody]Productos producto)
        {
            try
            {
                _context.productos.Add(producto);
                _context.SaveChanges();
                return CreatedAtRoute("GetProducto", new { id = producto.id_prod }, producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        // PUT: api/Productos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public ActionResult PutProductos(int id, [FromBody] Productos producto)
        {
            try
            {
                if (producto.id_prod == id)
                {
                    _context.Entry(producto).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetProducto", new { id = producto.id_prod }, producto);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Productos/5
        [HttpDelete("{id}")]
        public ActionResult DeleteProductos(int id)
        {
            try
            {
                var producto = _context.productos.FirstOrDefault(p => p.id_prod == id);
                if (producto != null)
                {
                    _context.productos.Remove(producto);
                    _context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
