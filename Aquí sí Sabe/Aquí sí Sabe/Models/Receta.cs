using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Models
{
    public class Receta
    {
        public int RecetaId { get; set; }
        public int UsuarioId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Ingredientes { get; set; }
        public string Pasos { get; set; }
        public string Categoria { get; set; }
        public string DireccionImagen { get; set; }
        public int Vistas { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string NombreUsuario { get; set; }
        public bool EsFavorito { get; set; }
    }
}