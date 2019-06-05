
using Microsoft.EntityFrameworkCore;
using TRABAJOFINAL.Models;

namespace TRABAJOFINAL.Data
{
    public class TrabajoFinalDbContext : DbContext
    {
       
        
        public DbSet<Mascota> Mascota { get; set; }
        public DbSet<CategoriaMasc> CategoriaMasc { get; set; }


        public TrabajoFinalDbContext(DbContextOptions<TrabajoFinalDbContext> o) : base(o) {

        }
    }
}