using System.ComponentModel.DataAnnotations;

namespace SistemaControlAportesCooperativa.Application.Dtos
{
    public class SocioDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del socio es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La cédula es obligatoria.")]
        [RegularExpression(@"^\d{3}-\d{7}-\d{1}$", ErrorMessage = "El formato de la cédula debe ser 000-0000000-0.")]
        public string Cedula { get; set; } = string.Empty;
    }
}