using Aquí_sí_Sabe.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Mappers
{
    public static class FavoritoMapper
    {
        public static Favorito Map(SqlDataReader reader)
        {
            return new Favorito
            {
                FavoritoId = (int)reader["FavoritoId"],
                UsuarioId = (int)reader["UsuarioId"],
                RecetaId = (int)reader["RecetaId"],
                FechaAgregada = Convert.ToDateTime(reader["FechaAgregada"])
            };
        }
    }
}