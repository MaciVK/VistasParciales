using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VistasParciales.Repositories;

namespace VistasParciales.Controllers
{
    public class HomeController : Controller
    {
        RepositoryGenerosMusicales repo;
        public HomeController(RepositoryGenerosMusicales repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {


            return View();
        }
        [HttpPost]
        public IActionResult Index(string accion)
        {
            if (accion == "guardar")
            {
                HttpContext.Session.SetString("HORA", DateTime.Now.ToString());
            }
            else if (accion == "borrar")
            {
                HttpContext.Session.Clear();
            }
            return View();
        }
        public IActionResult AutoresGenero(int idgenero)
        {
            return View(this.repo.GetAutoresGenero(idgenero));
        }
    }
}
