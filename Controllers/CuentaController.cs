using Microsoft.AspNetCore.Mvc;

namespace TRABAJOFINAL.Controllers
{
    public class CuentaController: Controller
    {
        public IActionResult Unetenos()
        {
            return View();
        }

         public IActionResult IniciarSesion()
        {
            return View();
        }

        public IActionResult CerrarSesion()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
    }
}