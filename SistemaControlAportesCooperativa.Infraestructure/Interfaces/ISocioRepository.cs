using SistemaControlAportesCooperativa.Domain.Entities;

namespace SistemaControlAportesCooperativa.Infrastructure.Interfaces
{
    public interface ISocioRepository
    {
        Task<IEnumerable<Socio>> GetAllAsync();
        Task<Socio?> GetByIdAsync(int id);
        Task AddAsync(Socio socio);
        void Update(Socio socio);
        void Delete(Socio socio);
        Task<bool> SaveChangesAsync();
    }
}