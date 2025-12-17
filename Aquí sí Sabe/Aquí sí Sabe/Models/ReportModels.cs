using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Models
{
    public class ReporteRecetaPopular
    {
        public int RecetaId { get; set; }
        public string Titulo { get; set; }
        public int Vistas { get; set; }
        public int ContadorFavoritos { get; set; }
        public int PuntuacionTotal
        {
            get
            {
                return Vistas + (ContadorFavoritos * 10);
            }
        }
    }

    public class ReporteActividadUsuario
    {
        public int TotalRecetasCreadas { get; set; }
        public int TotalRecetasFavoritas { get; set; }
        public string CategoriaMasUsada { get; set; }
        public List<string> UltimasRecetasVistas { get; set; }

        public ReporteActividadUsuario()
        {
            UltimasRecetasVistas = new List<string>();
        }
    }
}