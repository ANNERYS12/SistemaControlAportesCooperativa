namespace SistemaControlAportesCooperativa.Models
{
    public class Socio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal BalanceAportes { get; set; } 
    }
}