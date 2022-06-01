using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Api.Modelo
{
    public class Videojuego
    {
        [Key]
        public int IdJuego { get; set; }
        public string Titulo { get; set; }
        public string Consola { get; set; }
        public string Desarrollador { get; set; }
        public int Categoria { get; set; }
        public string Descripcion { get; set; }
    }
}
