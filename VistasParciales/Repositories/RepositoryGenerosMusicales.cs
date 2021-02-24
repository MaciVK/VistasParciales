using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VistasParciales.Data;
using VistasParciales.Models;

namespace VistasParciales.Repositories
{
    public class RepositoryGenerosMusicales
    {
        GenerosMusicalesContext context;
        public RepositoryGenerosMusicales(GenerosMusicalesContext context)
        {
            this.context = context;
        }
        public List<Genero> GetGeneros()
        {
            return this.context.Generos.ToList();
        }
        public List<Autor> GetAutoresGenero(int idgenero)
        {
            return this.context.Autores.Where(x => x.IdGenero == idgenero).ToList();
        }

    }
}
