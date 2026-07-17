using Microsoft.AspNetCore.Mvc;
using SistemaControlAportesCooperativa.Domain.Entities;
using SistemaControlAportesCooperativa.Infrastructure.Interfaces;
using System.Threading.Tasks;

namespace SistemaControlAportesCooperativa.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SocioController : ControllerBase
    {
        private readonly ISocioRepository _socioRepository;

        public SocioController(ISocioRepository socioRepository)
        {
            _socioRepository = socioRepository;
        }

        [HttpGet("estado-cuenta/{id}")]
        public async Task<IActionResult> ObtenerEstadoCuenta(int id)
        {
            var socio = await _socioRepository.GetByIdAsync(id);

            if (socio == null) return NotFound();

            return Ok(socio);
        }

        [HttpPost]
        public async Task<IActionResult> CrearSocio([FromBody] Socio nuevoSocio)
        {
            if (nuevoSocio == null) return BadRequest();

            await _socioRepository.AddAsync(nuevoSocio);
            await _socioRepository.SaveChangesAsync();

            return Ok(nuevoSocio);
        }
    }
}