using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace TRABAJOFINAL.Models
{
    public class Usuario:IdentityUser
    {
        
        public string direccion { get; set; }
        public string telefono { get; set; }
        public List<Alerta> Alertas { get; set; }
        public List<Mascota> Mascotas{get; set; }
    }
}