using SistemaControlAportesCooperativa.Domain.Entities;

namespace SistemaControlAportesCooperativa.Infrastructure.Interfaces
{
    public interface IAporteRepository
    {
        Task<IEnumerable<Aporte>> GetAllAsync();
        Task<Aporte?> GetByIdAsync(int id);
        Task<IEnumerable<Aporte>> GetBySocioIdAsync(int socioId);
        Task AddAsync(Aporte aporte);
        void Update(Aporte aporte);
        void Delete(Aporte aporte);
        Task<bool> SaveChangesAsync();
    }
}