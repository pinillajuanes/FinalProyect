using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Clase3Corte.Data
{
    public class Videojuego
    {
        [Key]
        public int IdJuego { get; set; }
        public string? Titulo { get; set; }
        public string? Consola { get; set; }
        public string? Desarrollador { get; set; }
        public string? Categoria { get; set; }
        public string? Descripcion { get; set; }
    }
}
