using Microsoft.EntityFrameworkCore;
using SistemaControlAportesCooperativa.Domain.Entities;
using SistemaControlAportesCooperativa.Infrastructure.Context;
using SistemaControlAportesCooperativa.Infrastructure.Core;
using SistemaControlAportesCooperativa.Infrastructure.Interfaces;

namespace SistemaControlAportesCooperativa.Infrastructure.Repositories
{
    public class AporteRepository : BaseRepository, IAporteRepository
    {
        public AporteRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Aporte>> GetAllAsync()
        {
            return await _context.Aportes.Include(a => a.Socio).ToListAsync();
        }

        public async Task<Aporte?> GetByIdAsync(int id)
        {
            return await _context.Aportes.Include(a => a.Socio)
                                         .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<IEnumerable<Aporte>> GetBySocioIdAsync(int socioId)
        {
            return await _context.Aportes.Where(a => a.SocioId == socioId).ToListAsync();
        }

        public async Task AddAsync(Aporte aporte)
        {
            await _context.Aportes.AddAsync(aporte);
        }

        public void Update(Aporte aporte)
        {
            _context.Aportes.Update(aporte);
        }

        public void Delete(Aporte aporte)
        {
            _context.Aportes.Remove(aporte);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}