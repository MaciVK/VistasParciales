using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VistasParciales.Models;
using VistasParciales.Repositories;

namespace VistasParciales.ViewComponents
{
    public class DropdownGenerosViewComponent : ViewComponent
    {
        RepositoryGenerosMusicales repo;
        public DropdownGenerosViewComponent(RepositoryGenerosMusicales repo)
        {
            this.repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Genero> generos = this.repo.GetGeneros();
            return View(generos);
        }
    }
}
