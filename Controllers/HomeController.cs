using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
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
                var user = _context.Usuarios.FirstOrDefault(x=> x.UserName == User.Identity.Name);
                al.usuarioId=user.Id;
                
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
                return RedirectToAction("validarSugerencias");
            }
          return View(sug);
        }
        public IActionResult validarSugerencias()
        {
          
          return View();
        }
        public IActionResult ListaSugerencias()
        {
          var Sugerencias= _context.Sugerencias.ToList();
          return View(Sugerencias);  
         
        }

        public IActionResult Donaciones()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        [HttpPost]
         public IActionResult Donaciones(Donaciones d)
        {
          if(ModelState.IsValid){
            if(d.Tipo!="tipo"){
                d.fecha=DateTime.Now;
                _context.Donaciones.Add(d);
                _context.SaveChanges();
                
                if(d.Tipo=="monetario"){
                  return RedirectToAction("ValidarDonacionMone");
                }else{
                    return RedirectToAction("ValidarDonacionHUma");

                }
              }else{
                  
                return RedirectToAction("Donaciones");
                
              }
                
            }
          return View(d);
        }

        public IActionResult ValidarDonacionMone()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        public IActionResult donacionFinalizadaMOnetaria()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        public IActionResult ValidarDonacionHUma()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
