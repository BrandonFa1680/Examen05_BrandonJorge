﻿using System.Text.Json.Serialization;

namespace Examen05_BrandonJorge.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        [JsonIgnore]
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

    }
}
