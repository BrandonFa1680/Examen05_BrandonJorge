using Examen05_BrandonJorge.Models;
using Examen05_BrandonJorge.Request;
using Examen05_BrandonJorge.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen05_BrandonJorge.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        public List<ProductoResponse> ListarProductos()
        {
            using(var context = new DemoContext())
            {
                var productos = context.Productos.ToList();
                var categorias = context.Categorias.ToList();
                var response = productos.Select(x => new ProductoResponse
                {
                    ProductoId = x.ProductoId,
                    Nombre = x.Nombre,
                    Precio = x.Precio,
                    NombreCategoria = x.Categoria.NombreCategoria
                }).ToList();
                return response;
            }
        }

        [HttpGet]
        public List<ProductoResponse> ListarProductoxID(int id)
        {
            using( var context = new DemoContext())
            {
                var productos = context.Productos.ToList();
                var categorias = context.Categorias.ToList();
                var response = productos.Where(x=> x.ProductoId == id).Select(x=>
                new ProductoResponse
                {
                    ProductoId = x.ProductoId,
                    Nombre = x.Nombre,
                    Precio = x.Precio,
                    NombreCategoria = x.Categoria.NombreCategoria
                }).ToList();
                return response;
            }
        }

        [HttpPost]
        public bool InsertarProducto(ProductoRequest request)
        {
            try
            {
                using(var context = new DemoContext())
                {
                    Producto producto = new Producto
                    {
                        Nombre = request.Nombre,
                        Precio = request.Precio,
                        CategoriaId = request.CategoriaId
                    };
                    context.Add(producto);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
    }
}
