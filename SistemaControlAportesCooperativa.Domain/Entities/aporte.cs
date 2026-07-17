using SistemaControlAportesCooperativa.Domain.Core;

namespace SistemaControlAportesCooperativa.Domain.Entities
{
    public class Aporte : BaseEntity
    {
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public int SocioId { get; set; }
        public Socio? Socio { get; set; }
    }
}