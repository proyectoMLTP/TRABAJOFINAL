using System.ComponentModel.DataAnnotations;

namespace TRABAJOFINAL.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string Usuario { get; set; }   

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}