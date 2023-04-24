using System.ComponentModel.DataAnnotations;

namespace AR_PROGRESO1.Models
{
    public class ARAURA
    {
        [Required(ErrorMessage = "Escriba el codigo.")]
        [RegularExpression("^[0-9]{9}-[0-9]{1}$", ErrorMessage = "Escriba un codigo valido.")]
        [Key]
        public int arCodigo { get; set; }

        [Required(ErrorMessage = "Escriba la calificacion final.")]
        [Range(0.01, 10.0)]
        public decimal arCalificacionFinal { get; set; }

        [Required(ErrorMessage = "Escriba el nombre y apellido.")]
        [MinLength(5, ErrorMessage = "Escriba al menos 5 caractéres.")]
        [MaxLength(50, ErrorMessage = "Escriba un máximo de 5 caractéres.")]
        public string? arNombre { get; set; }

        [Required(ErrorMessage = "Escriba el correo.")]
        [EmailAddress(ErrorMessage = "Escriba un correo válido.")]
        public string? arCorreo { get; set; }

        [Required(ErrorMessage = "Escriba el codigo postal.")]
        public string? arCodigoPostal { get; set; }

        public bool arEstudianteNuevo { get; set; }

        [Required(ErrorMessage = "Escriba la fecha de nacimiento.")]
        public DateTime arFechaNacimiento { get; set; }

        [Required(ErrorMessage = "Escriba la calificacion final.")]
        [Range(0.01, 5.0)]
        public float arPromedioConducta { get; set; }
    }
}
