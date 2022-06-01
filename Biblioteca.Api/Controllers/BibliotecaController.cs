#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Api.Data;
using Biblioteca.Api.Modelo;

namespace Biblioteca.Api.Controllers
{
    [Route("[controller]/[action]")]
    public class BibliotecaController : ControllerBase
    {
        private readonly BibliotecaApiContext _context;
        private Comida Comida;
        private Videojuego Videojuego;

        public BibliotecaController(BibliotecaApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ConsultarComida()
        {
            return Ok(await _context.Comidas.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> AgregarComida(Comida comida)
        {
            _context.Comidas.Add(comida);
            await _context.SaveChangesAsync();
            return Ok(comida);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarComida(Comida comida)
        {
            _context.Update(comida);
            await _context.SaveChangesAsync();
            return Ok(comida);
        }

        [HttpDelete]
        public async Task<IActionResult> BorrarComida(Comida comida)
        {
            _context.Remove(comida);
            await _context.SaveChangesAsync();
            return Ok(comida);
        }

        //Videojuego
        [HttpGet]
        public async Task<IActionResult> ConsultarVideojuegos()
        {
            return Ok(await _context.Videojuego.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> AgregarVideojuegos(Videojuego videojuego)
        {
            _context.Videojuego.Add(videojuego);
            await _context.SaveChangesAsync();
            return Ok(videojuego);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarVideojuegos(Videojuego videojuego)
        {
            _context.Update(videojuego);
            await _context.SaveChangesAsync();
            return Ok(videojuego);
        }

        [HttpDelete]
        public async Task<IActionResult> BorrarVideojuegos(Videojuego videojuego)
        {
            _context.Videojuego.Remove(videojuego);
            await _context.SaveChangesAsync();
            return Ok(videojuego);
        }


    }
}
