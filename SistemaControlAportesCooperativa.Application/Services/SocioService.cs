using SistemaControlAportesCooperativa.Application.Contract;
using SistemaControlAportesCooperativa.Application.Dtos;
using SistemaControlAportesCooperativa.Domain.Entities;
using SistemaControlAportesCooperativa.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaControlAportesCooperativa.Application.Services
{
    public class SocioService : ISocioService
    {
        private readonly ISocioRepository _socioRepository;

        public SocioService(ISocioRepository socioRepository)
        {
            _socioRepository = socioRepository;
        }

        public async Task<IEnumerable<SocioDto>> ObtenerTodosAsync()
        {
            var socios = await _socioRepository.GetAllAsync();
            return socios.Select(s => new SocioDto
            {
                Id = s.Id,
                Nombre = s.Nombre
            });
        }

        public async Task<SocioDto?> ObtenerPorIdAsync(int id)
        {
            var socio = await _socioRepository.GetByIdAsync(id);
            if (socio == null) return null;

            return new SocioDto
            {
                Id = socio.Id,
                Nombre = socio.Nombre
            };
        }

        public async Task<SocioDto> CrearSocioAsync(SocioDto socioDto)
        {
            var socio = new Socio
            {
                Nombre = socioDto.Nombre
            };

            await _socioRepository.AddAsync(socio);
            await _socioRepository.SaveChangesAsync();

            socioDto.Id = socio.Id;
            return socioDto;
        }
    }
}