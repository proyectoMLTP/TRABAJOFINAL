using Microsoft.EntityFrameworkCore;
namespace TrabajoFinalMultiplataforma.Data

{
    public class TrabajoFinalMultiplataformaDbContext: DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<CategoriaUsuarios> CategoriaUsuarios { get; set; }
        
        public DbSet<Mascotas> Mascotas { get; set; }
        public DbSet<CategoriaMasc> CategoriaMasc { get; set; }

        public TrabajoFinalMultiplataformaDbContext(DbContextOptions<TrabajoFinalMultiplataforma> o) : base(o) {

        }
    }
}