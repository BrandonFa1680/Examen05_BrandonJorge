using Examen05_BrandonJorge.Models;

namespace Examen05_BrandonJorge.Request
{
    public class CategoriaRequest
    {
        public string Nombre { get; set; }
        public string Descripcion {  get; set; }

        public List<Producto> Productos { get; set; }
    }
}
