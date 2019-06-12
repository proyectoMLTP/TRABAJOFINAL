using System.ComponentModel.DataAnnotations;

namespace TRABAJOFINAL.ViewModels
{
    public class LoginViewModel
    {
           

        [Required]
        public string Email { get; set; }   

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}