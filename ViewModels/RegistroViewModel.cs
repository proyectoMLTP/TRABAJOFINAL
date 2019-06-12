using System.ComponentModel.DataAnnotations;

namespace TRABAJOFINAL.ViewModels
{
    public class RegistroViewModel
    {
        [Required]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string direccion { get; set; }
        
        [Required]
        public string telefono { get; set; }
    }
}