using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Clase3Corte.Data
{
    public class Comida
    {
        [Key]
        public int IdComida { get; set; }
        public string? Nombre { get; set; }
        public string? Categoria { get; set; }
        public string? PaisOrigen { get; set; }
        public int Costo { get; set; }
        public string? Descripcion { get; set; }
    }
}