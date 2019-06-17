namespace TRABAJOFINAL.Models
{
    public class Mascota
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string categoria { get; set; }
        public string estado { get; set; }
        public string foto { get; set; }
        public string usuarioId { get; set; }

        public virtual Usuario usuario { get; set; }
        
    }
}