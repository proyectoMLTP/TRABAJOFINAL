using Microsoft.AspNetCore.Mvc;

namespace TRABAJOFINAL.Controllers
{
    public class MascotaController:Controller
    {
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
          //TODO: Implement Realistic Implementation
          return View();
        }
        public IActionResult DarAdopcion()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
    }
}