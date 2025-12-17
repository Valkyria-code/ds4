using Aquí_sí_Sabe.Data;
using Aquí_sí_Sabe.Models;
using Aquí_sí_Sabe.Mappers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace Aquí_sí_Sabe.Repositorios
{
    public class VistaRecetaRepositorio
    {
        //método 1: insertar vista de receta
        public void Insert(int? usuarioId, int recetaId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    insert into VistasReceta (UsuarioId, RecetaId)
                    values (@usuarioId, @recetaId)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioId", (object)usuarioId ?? DBNull.Value);
                command.Parameters.AddWithValue("@recetaId", recetaId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //método 2: últimas recetas vistas por un usuario`
        public List<Receta> GetRecentByUsuarioId(int usuarioId, int count)
        {
            List<Receta> recetas = new List<Receta>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    select top (@count) R.*
                    from Recetas R
                    inner join VistasReceta V
                    on R.RecetaId = V.RecetaId
                    where V.UsuarioId = @usuarioId
                    order by V.FechaVista desc";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioId", usuarioId);
                command.Parameters.AddWithValue("@count", count);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        recetas.Add(RecetaMapper.Map(reader));
                    }
                }
            }

            return recetas;
        }
    }
}