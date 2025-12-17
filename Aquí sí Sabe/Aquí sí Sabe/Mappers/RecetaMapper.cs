using Aquí_sí_Sabe.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Mappers
{
    public static class RecetaMapper
    {
        public static Receta Map(SqlDataReader reader)
        {
            return new Receta
            {
                RecetaId = (int)reader["RecetaId"],
                UsuarioId = (int)reader["UsuarioId"],
                Titulo = reader["Titulo"].ToString(),
                Descripcion = reader["Descripcion"].ToString(),
                Ingredientes = reader["Ingredientes"].ToString(),
                Pasos = reader["Pasos"].ToString(),
                Categoria = reader["Categoria"].ToString(),
                Vistas = (int)reader["Vistas"],
                DireccionImagen = reader["DireccionImagen"] == DBNull.Value ? null : reader["DireccionImagen"].ToString(),
                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"])
            };
        }
    }
}