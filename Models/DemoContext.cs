using Microsoft.EntityFrameworkCore;

namespace Examen05_BrandonJorge.Models
{
    public class DemoContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-B6LJ1PH\\SQLEXPRESS;" +
                "Database= Examen05;Integrated Security=True ; " +
                "Trust Server Certificate= True");
        }

    }
}
