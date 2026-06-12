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
}