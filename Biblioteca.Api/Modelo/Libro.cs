using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Api.Modelo
{
    public class Comida
    {
        [Key]
        public int IdComida { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string PaisOrigen { get; set; }
        public int Pagina { get; set; }
        public string Descripcion { get; set; }
    }
}
