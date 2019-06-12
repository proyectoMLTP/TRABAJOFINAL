namespace TRABAJOFINAL.Models
{
    public class Alerta
    {
        public string  nombre { get; set; }

        public string telefono { get; set; }

        public string descripcion { get; set; }


        public Usuario usuario { get; set; }
    }
}