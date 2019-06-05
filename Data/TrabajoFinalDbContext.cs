
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TRABAJOFINAL.Models;

namespace TRABAJOFINAL.Data
{
    public class TrabajoFinalDbContext : IdentityDbContext
    {
       
        
        public DbSet<Mascota> Mascota { get; set; } 
        

        public DbSet<Donaciones> Donaciones{get; set;}

        public DbSet<Tipo> Tipo{get; set;}


        


        public TrabajoFinalDbContext(DbContextOptions<TrabajoFinalDbContext> o) : base(o) {

        }
    }
}