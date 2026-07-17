using SistemaControlAportesCooperativa.Domain.Core;

namespace SistemaControlAportesCooperativa.Domain.Entities
{
    public class Socio : BaseEntity
    {
        public string Nombre { get; set; } = string.Empty;
        public string Identificacion { get; set; } = string.Empty;
        public DateTime FechaIngreso { get; set; }
        public decimal BalanceAportes { get; set; }
    }
}