using Microsoft.AspNetCore.Mvc;
using SistemaControlAportesCooperativa.Data;
using SistemaControlAportesCooperativa.Models;
using System;
namespace SistemaControlAportesCooperativa.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SocioController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SocioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("estado-cuenta/{id}")]
        public IActionResult ObtenerEstadoCuenta(int id)
        {
            var socio = _context.Socios.Find(id);

            if (socio == null) return NotFound();

            return Ok(socio);
        }
        [HttpPost]
        public IActionResult CrearSocio([FromBody] Socio nuevoSocio)
        {
            _context.Socios.Add(nuevoSocio);
            _context.SaveChanges();
            return Ok(nuevoSocio);
        } 
    } 
} 