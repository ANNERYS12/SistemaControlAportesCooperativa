using System.ComponentModel.DataAnnotations;

public class SocioDTO
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(100)]
    public string Nombre { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Formato de correo incorrecto")]
    public string Email { get; set; }
}