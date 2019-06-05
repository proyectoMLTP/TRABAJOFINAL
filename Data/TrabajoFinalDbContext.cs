
namespace TRABAJOFINAL.Data
{
    public class TrabajoFinalDbContext : DbContext
    {
       public DbSet<Usuarios> Usuarios  {get; set} 
       public DbSet<CategoriaUsuarios> CategoriaUsuarios { get; set; }
        
        public DbSet<Mascotas> Mascotas { get; set; }
        public DbSet<CategoriaMasc> CategoriaMasc { get; set; }
    }
}