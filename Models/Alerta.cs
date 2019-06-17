namespace TRABAJOFINAL.Models
{
    public class Alerta
    {
        public int Id { get; set; }
        public string  nombre { get; set; }

        public string telefono { get; set; }
        public string direccion { get; set; }

        public string descripcion { get; set; }
        public string tipo { get; set; }

        public string usuarioId { get; set; }


        public Usuario usuario { get; set; }
    }
}