namespace Examen05_BrandonJorge.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion {  get; set; }
        public List<Producto> Productos { get; set; }

    }
}
