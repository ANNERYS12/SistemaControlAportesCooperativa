using SistemaControlAportesCooperativa.Infrastructure.Context;

namespace SistemaControlAportesCooperativa.Infrastructure.Core
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        protected BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}