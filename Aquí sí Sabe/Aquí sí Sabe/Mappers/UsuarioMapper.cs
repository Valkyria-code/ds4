using Aquí_sí_Sabe.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Mappers
{
    public static class UsuarioMapper
    {
        public static Usuario Map(SqlDataReader reader)
        {
            return new Usuario
            {
                UsuarioId = (int)reader["UsuarioId"],
                NombreUsuario = reader["NombreUsuario"]?.ToString(),
                Email = reader["Email"]?.ToString(),
                PasswordHash = reader["PasswordHash"]?.ToString(),
                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
            };
        }
    }
}