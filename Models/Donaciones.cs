using System;

namespace TRABAJOFINAL.Models
{
    public class Donaciones
    {
        public int Id { get; set; }
        
        
        public string Tipo { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }

        public string Nombre { get; set; }
    }
}