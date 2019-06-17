using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TRABAJOFINAL.Data;
using TRABAJOFINAL.Models;

namespace TRABAJOFINAL.Controllers
{
    public class MascotaController:Controller
    {
      TrabajoFinalDbContext _con;

      public MascotaController(TrabajoFinalDbContext tr){
        _con=tr;

      }
        public IActionResult Mascotas()
        {
            return View();
        }
        
        public IActionResult Esterilizacion()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        public IActionResult Adoptar()
        {
          var mascotas= _con.Mascota.ToList();
          return View(mascotas);
        }
        public IActionResult DarAdopcion()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        [HttpPost]
        public IActionResult DarAdopcion(Mascota masc)
        {
           if(ModelState.IsValid){
                if(masc.categoria!="SEXO"){
                    masc.estado="Espera para ser adoptar";
                    _con.Mascota.Add(masc);
                    _con.SaveChanges();
                    return RedirectToAction("Mascota");
                }else
                {
                  
                  return RedirectToAction("DarAdopcion");
                }
            }
            
        
          return View(masc);
        }
    }
}