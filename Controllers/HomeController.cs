using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TRABAJOFINAL.Data;
using TRABAJOFINAL.Models;

namespace TRABAJOFINAL.Controllers
{
    public class HomeController : Controller
    {
        private TrabajoFinalDbContext _context;

        public HomeController(TrabajoFinalDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Nosotros()
        {
            return View();
        }

        public IActionResult ValidarForm()
        {
            return View();
        }
        public IActionResult Alertas()
        {
          
          return View();
        }
        [HttpGet]     
        public IActionResult Formualrioalertas(string id)
        {
            ViewBag.id=id;
            return View();
        }
        [HttpPost]
        public IActionResult Formualrioalertas(Alerta al)
        {
            if(ModelState.IsValid){
                _context.Alertas.Add(al);
                _context.SaveChanges();
                return RedirectToAction("ValidarForm");
            }
            return View(al);
        }

        

        public IActionResult Sugerencias()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        [HttpPost]
        public IActionResult Sugerencias(Sugerencias sug)
        {
          if(ModelState.IsValid){
                _context.Sugerencias.Add(sug);
                _context.SaveChanges();
                return RedirectToAction("ValidarForm");
            }
          return View(sug);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
