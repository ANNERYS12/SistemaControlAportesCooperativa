using SistemaControlAportesCooperativa.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaControlAportesCooperativa.Application.Contract
{
    public interface ISocioService
    {
        Task<IEnumerable<SocioDto>> ObtenerTodosAsync();
        Task<SocioDto?> ObtenerPorIdAsync(int id);
        Task<SocioDto> CrearSocioAsync(SocioDto socioDto);
    }
}