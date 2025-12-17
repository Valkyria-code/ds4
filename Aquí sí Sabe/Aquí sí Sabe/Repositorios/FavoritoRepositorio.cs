using Aquí_sí_Sabe.Data;
using Aquí_sí_Sabe.Models;
using Aquí_sí_Sabe.Mappers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Repositorios
{
    public class FavoritoRepositorio
    {
        //método 1: obtener favoritos por usuario
        public List<Favorito> GetByUsuarioId(int usuarioId)
        {
            List<Favorito> favoritos = new List<Favorito>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "select * from Favoritos where UsuarioId = @usuarioId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioId", usuarioId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        favoritos.Add(FavoritoMapper.Map(reader));
                    }
                }
            }

            return favoritos;
        }

        //método 2: obtener recetas favoritas de un usuario
        public List<Receta> GetRecetasByUsuarioId(int usuarioId)
        {
            List<Receta> recetas = new List<Receta>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    select R.* 
                    from Recetas R
                    inner join Favoritos F
                    on R.RecetaId = F.RecetaId
                    where F.UsuarioId = @usuarioId
                    order by F.FechaAgregada desc";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioId", usuarioId);

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

        //método 3: verificar si una receta ya es favorita
        public bool EsFavorito(int usuarioId, int recetaId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    select count(*) 
                    from Favoritos 
                    where UsuarioId = @usuarioId
                    and RecetaId = @recetaId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioId", usuarioId);
                command.Parameters.AddWithValue("@recetaId", recetaId);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        //étodo 4: agregar receta a favoritos
        public bool Insert(int usuarioId, int recetaId)
        {
            if (EsFavorito(usuarioId, recetaId))
                return false;

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    insert into Favoritos (UsuarioId, RecetaId)
                    values (@usuarioId, @recetaId)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioId", usuarioId);
                command.Parameters.AddWithValue("@recetaId", recetaId);

                connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
        }

        //método 5: quitar receta de favoritos
        public bool Delete(int usuarioId, int recetaId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    delete from Favoritos 
                    where UsuarioId = @usuarioId
                    and RecetaId = @recetaId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioId", usuarioId);
                command.Parameters.AddWithValue("@recetaId", recetaId);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        //método 6: contar favoritos por receta
        public int GetConteoFavorito(int recetaId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    select count(*)
                    from Favoritos
                    where RecetaId = @recetaId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@recetaId", recetaId);

                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
    }
}