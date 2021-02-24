using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VistasParciales.Models;

namespace VistasParciales.Data
{
    public class GenerosMusicalesContext:DbContext
    {
        public GenerosMusicalesContext(DbContextOptions<GenerosMusicalesContext> options) : base(options) { }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Autor> Autores{ get; set; }
    }
}
