using System.ComponentModel.DataAnnotations;

namespace TRABAJOFINAL.Models
{
    public class Sugerencias
    {
        public int Id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string correo { get; set; }
        public string mensaje { get; set; }
    }
}