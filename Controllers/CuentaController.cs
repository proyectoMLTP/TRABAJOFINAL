using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TRABAJOFINAL.Data;
using TRABAJOFINAL.Models;
using TRABAJOFINAL.ViewModels;

namespace TRABAJOFINAL.Controllers
{
    public class CuentaController: Controller
    {
        private TrabajoFinalDbContext _context;
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;

        public CuentaController(
            TrabajoFinalDbContext t,
            UserManager<IdentityUser> um,
            SignInManager<IdentityUser> sim

        ){
            _context=t;
            _userManager =um;
            _signInManager =sim;
        }
        public IActionResult Unetenos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Unetenos(RegistroViewModel vm)
        {
            if(ModelState.IsValid){
                var user = new Usuario();
                user.UserName=vm.Usuario;
                user.Email=vm.Email;
                user.direccion=vm.direccion;
                user.telefono=vm.telefono;
                
                
                var resultado = _userManager.CreateAsync(user, vm.Password);

                if(resultado.Result==IdentityResult.Success){
                    return RedirectToAction("Index", "home");
                }else{
                    foreach(var error in resultado.Result.Errors){
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(vm);
        }

         public IActionResult IniciarSesion()
        {
            
            return View();
        }


        [HttpPost]
        public IActionResult IniciarSesion(LoginViewModel lv)
        {
            if(ModelState.IsValid){
                

                var resultado = _signInManager.PasswordSignInAsync(lv.Usuario, lv.Password, false, false);

                if(resultado.Result.Succeeded){
                    return RedirectToAction("Index", "home");
                }else{
                    
                        ModelState.AddModelError("", "Error en contraseña o usuario");
                    
                }
            }
            return View(lv);
        }

        public IActionResult CerrarSesion()
        {
          _signInManager.SignOutAsync();
          return RedirectToAction("Index", "home");
        }
    }
}