using Examen05_BrandonJorge.Models;

namespace Examen05_BrandonJorge.Response
{
    public class CategoriaResponse
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion {  get; set; }
        public List<Producto> Productos { get; set; }
    }
}
