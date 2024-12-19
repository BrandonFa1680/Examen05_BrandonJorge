using Examen05_BrandonJorge.Models;
using Examen05_BrandonJorge.Request;
using Examen05_BrandonJorge.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Examen05_BrandonJorge.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet]
        public List<Categoria> ListarCategorias()
        {
            using (var context = new DemoContext())
            {
                var categorias = context.Categorias.Include(x => x.Productos).ToList();

                return categorias;
            }
        }

        [HttpGet]
        public List<CategoriaResponse> ListarCategoriasxID(int id)
        {
            using (var context = new DemoContext())
            {
                var categorias = context.Categorias.Include(x => x.Productos).ToList();
                var response = categorias.Where(x => x.CategoriaId == id).Select(x =>
                new CategoriaResponse
                {
                    CategoriaId = x.CategoriaId,
                    Nombre = x.NombreCategoria,
                    Descripcion = x.Descripcion,
                    Productos = x.Productos
                    
                }).ToList();
                return response;
            }
        }

        [HttpPost]
        public bool InsertarCategorias(CategoriaRequest request)
        {
            try
            {
                using (var context = new DemoContext())
                {
                    Categoria categoria = new Categoria
                    {
                        NombreCategoria = request.Nombre,
                        Descripcion = request.Descripcion
                    };
                    context.Add(categoria);
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
