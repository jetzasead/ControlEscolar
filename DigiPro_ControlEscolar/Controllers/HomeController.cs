using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DigiPro_ControlEscolar.Models;
using DigiPro_ControlEscolar.ViewsModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace DigiPro_ControlEscolar.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext _myDbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyDbContext myDbContext)
        {
            _logger = logger;
            _myDbContext = myDbContext;
        }

        public IActionResult Index()
        {

            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(loginViewModelo model) {

            var user = await _myDbContext.Alumno
                .FirstOrDefaultAsync(u => u.Nombre == model.Input.Nombre && u.ApPaterno == model.Input.Apellido);
            if (user== null)
            {
                return RedirectToAction("Index","");
            }
            else
            {
                return RedirectToAction("Index", "Alumnoes");
           }    
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
