using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Models
{
    public class VistaReceta
    {
        public int VistaId { get; set; }
        public int? UsuarioId { get; set; }
        public int RecetaId { get; set; }
        public DateTime FechaVista { get; set; }
    }
}