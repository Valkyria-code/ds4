using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Models
{
    public class Favorito
    {
        public int FavoritoId { get; set; }
        public int UsuarioId { get; set; }
        public int RecetaId { get; set; }
        public DateTime FechaAgregada { get; set; }
    }
}