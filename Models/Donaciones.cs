using System;

namespace TRABAJOFINAL.Models
{
    public class Donaciones
    {
        public int Id { get; set; }
        public Usuario Nombre { get; set; }
        public Tipo Tipo { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
    }
}