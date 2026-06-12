using Microsoft.AspNetCore.Mvc;
using SistemaControlAportesCooperativa.Dtos; 

namespace SistemaControlAportesCooperativa.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SocioController : ControllerBase
    {
        // POST: api/socio
        [HttpPost]
        public IActionResult CrearSocio([FromBody] SocioDTO socioDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(new { mensaje = "Socio registrado con éxito", socio = socioDto });
        }
    } 
    [HttpGet("estado-cuenta/{id}")]
public IActionResult ObtenerEstadoCuenta(int id)
{
    var estadoCuenta = new { 
        SocioId = id, 
        Nombre = "Socio Ejemplo",
        SaldoPendiente = 1500.50,
        FechaUltimoAporte = DateTime.Now.AddDays(-5),
        Estado = "Activo"
    };

    return Ok(estadoCuenta);
}
}