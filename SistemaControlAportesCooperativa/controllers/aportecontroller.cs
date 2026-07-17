using Microsoft.AspNetCore.Mvc;
using SistemaControlAportesCooperativa.Domain.Entities;
using SistemaControlAportesCooperativa.Infrastructure.Interfaces;
using SistemaControlAportesCooperativa.DTO;
using System;
using System.Threading.Tasks;

namespace SistemaControlAportesCooperativa.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AporteController : ControllerBase
    {
        private readonly IAporteRepository _aporteRepository;

        public AporteController(IAporteRepository aporteRepository)
        {
            _aporteRepository = aporteRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CrearAporte([FromBody] AporteDTO aporteDto)
        {
            if (aporteDto == null) return BadRequest();

            var aporte = new Aporte
            {
                Monto = aporteDto.Monto,
                SocioId = aporteDto.SocioId,
                Fecha = DateTime.Now
            };

            await _aporteRepository.AddAsync(aporte);
            await _aporteRepository.SaveChangesAsync();

            return Ok(aporte);
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerAportes()
        {
            var aportes = await _aporteRepository.GetAllAsync();
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