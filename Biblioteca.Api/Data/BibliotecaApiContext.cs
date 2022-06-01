﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Api.Modelo;

namespace Biblioteca.Api.Data
{
    public class BibliotecaApiContext : DbContext
    {
        public BibliotecaApiContext (DbContextOptions<BibliotecaApiContext> options)
            : base(options)
        {
        }

        public DbSet<Biblioteca.Api.Modelo.Comida> Comidas { get; set; }
        public DbSet<Biblioteca.Api.Modelo.Videojuego> Videojuego { get; set; }
    }
}
