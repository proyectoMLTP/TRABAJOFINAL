using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
         
          return View();
        }
        [HttpPost]
        public IActionResult Esterilizacion(Mascota masc)
        {
          if(ModelState.IsValid){
            var user = _con.Usuarios.FirstOrDefault(x=> x.UserName == User.Identity.Name);
            masc.usuarioId=user.Id;
                if(masc.categoria!="SEXO"){
                   masc.estado="Para proceso de esterilización";
                    _con.Mascota.Add(masc);
                    _con.SaveChanges();
                    return RedirectToAction("ProcesoEsterilizacion");
                }else
                {
                  
                  return RedirectToAction("Esterilizacion");
                }
            }
          
          return View(masc);
        }
        public IActionResult ProcesoEsterilizacion()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        public IActionResult Adoptar()
        {
          var mascotas= _con.Mascota.Where(X=> X.estado=="En adopcion").ToList();
          return View(mascotas);
        }
        public IActionResult MascotasRescatadas()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        [HttpPost]
        public IActionResult MascotasRescatadas(Mascota masc)
        {
           if(ModelState.IsValid){
             
                if(masc.categoria!="SEXO"){
                    masc.estado="Mascota rescatada; esperando diagnostico";
                    _con.Mascota.Add(masc);
                    _con.SaveChanges();
                    return RedirectToAction("ListaMascota");
                }else
                {
                  
                  return RedirectToAction("MascotasRescatadas");
                }
            }
            
        
          return View(masc);
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
              var user = _con.Usuarios.FirstOrDefault(x=> x.UserName == User.Identity.Name);
              masc.usuarioId=user.Id;
                if(masc.categoria!="SEXO"){
                    masc.estado="Espera para ser adoptado";
                    _con.Mascota.Add(masc);
                    _con.SaveChanges();
                    return RedirectToAction("GraciasDarAdopcion");
                }else
                {
                  
                  return RedirectToAction("DarAdopcion");
                }
            }
            
        
          return View(masc);
        }
        public IActionResult GraciasDarAdopcion()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        public IActionResult ListaMascota()
        {
          
         
          var mascotas= _con.Mascota.ToList();
          return View(mascotas);
        }

        public IActionResult Actualizar(int id)
        {
            var p = _con.Mascota.FirstOrDefault(x => x.id == id);
            

            if (p == null) {
                return NotFound();
            }

            return View(p);
        }

        [HttpPost]
        public IActionResult Actualizar(Mascota m)
        {
            if (ModelState.IsValid) {
              if(m.estado!="estado"){
                    var mascot = _con.Mascota.Find(m.id);
                    mascot.estado = m.estado;
                    _con.SaveChanges();
                    return RedirectToAction("ListaMascota");
                }else
                {
                  
                  return RedirectToAction("Actualizar");
                }
            }

            return View(m);
        }

        public IActionResult Borrar(int id)
        {
            var p = _con.Mascota.FirstOrDefault(x => x.id == id);

            if (p != null) {
                _con.Mascota.Remove(p);
                _con.SaveChanges();
            }

            return RedirectToAction("ListaMascota");
        }
    }
}