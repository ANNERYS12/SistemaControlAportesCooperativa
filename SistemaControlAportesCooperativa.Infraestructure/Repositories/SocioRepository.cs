using Microsoft.EntityFrameworkCore;
using SistemaControlAportesCooperativa.Domain.Entities;
using SistemaControlAportesCooperativa.Infrastructure.Context;
using SistemaControlAportesCooperativa.Infrastructure.Core;
using SistemaControlAportesCooperativa.Infrastructure.Interfaces;

namespace SistemaControlAportesCooperativa.Infrastructure.Repositories
{
    public class SocioRepository : BaseRepository, ISocioRepository
    {
        public SocioRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Socio>> GetAllAsync()
        {
            return await _context.Socios.ToListAsync();
        }

        public async Task<Socio?> GetByIdAsync(int id)
        {
            return await _context.Socios.FindAsync(id);
        }

        public async Task AddAsync(Socio socio)
        {
            await _context.Socios.AddAsync(socio);
        }

        public void Update(Socio socio)
        {
            _context.Socios.Update(socio);
        }

        public void Delete(Socio socio)
        {
            _context.Socios.Remove(socio);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}