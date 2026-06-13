using Microsoft.AspNetCore.Mvc;
using SistemaControlAportesCooperativa.Data;
using SistemaControlAportesCooperativa.Models;
using SistemaControlAportesCooperativa.DTO; 

namespace SistemaControlAportesCooperativa.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AporteController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AporteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CrearAporte([FromBody] AporteDTO aporteDto)
        {
            var aporte = new Aporte
            {
                Monto = aporteDto.Monto,
                SocioId = aporteDto.SocioId,
                Fecha = DateTime.Now 
            };

            _context.Aportes.Add(aporte);
            _context.SaveChanges();

            return Ok(aporte);
        }

        [HttpGet]
        public IActionResult ObtenerAportes()
        {
            var aportes = _context.Aportes.ToList();
            return Ok(aportes);
        }
    }
}

namespace SistemaControlAportesCooperativa.DTO
{
    public class AporteDTO
    {
        public decimal Monto { get; set; }
        public int SocioId { get; set; }
    }
}