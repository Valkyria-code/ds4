using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Models
{
    public class Usuario
    {
        public int  UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}