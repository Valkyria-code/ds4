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
    public class RecetaRepositorio
    {
        //método 1: obtener todas las recetas
        public List<Receta> GetAll()
        {
            List<Receta> recetas = new List<Receta>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "select * from Recetas order by FechaCreacion desc";
                SqlCommand command = new SqlCommand(query, connection);

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

        //método 2: obtener receta por id
        public Receta GetById(int recetaId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "select * from Recetas where RecetaId = @recetaId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@recetaId", recetaId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return RecetaMapper.Map(reader);
                    }
                }
            }

            return null;
        }

        //método 3: obtener recetas por usuario
        public List<Receta> GetByUsuarioId(int usuarioId)
        {
            List<Receta> recetas = new List<Receta>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "select * from Recetas where UsuarioId = @usuarioId";
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

        //método 4: filtrar recetas por categoría
        public List<Receta> GetByCategoria(string categoria)
        {
            List<Receta> recetas = new List<Receta>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "select * from Recetas where Categoria = @categoria";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@categoria", categoria);

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

        //método 5: buscar recetas por título o ingredientes
        public List<Receta> Search(string queryTexto)
        {
            List<Receta> recetas = new List<Receta>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    select * from Recetas 
                    where Titulo like @query or Ingredientes like @query";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@query", "%" + queryTexto + "%");

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

        //método 6: insertar nueva receta
        public int Insert(Receta receta)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    insert into Recetas 
                    (UsuarioId, Titulo, Descripcion, Ingredientes, Pasos, Categoria, DireccionImagen)
                    values 
                    (@usuarioId, @titulo, @descripcion, @ingredientes, @pasos, @categoria, @direccionImagen);
                    select scope_identity();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioId", receta.UsuarioId);
                command.Parameters.AddWithValue("@titulo", receta.Titulo);
                command.Parameters.AddWithValue("@descripcion", receta.Descripcion);
                command.Parameters.AddWithValue("@ingredientes", receta.Ingredientes);
                command.Parameters.AddWithValue("@pasos", receta.Pasos);
                command.Parameters.AddWithValue("@categoria", receta.Categoria);
                command.Parameters.AddWithValue("@direccionImagen", receta.DireccionImagen ?? (object)DBNull.Value);

                connection.Open();
                object result = command.ExecuteScalar();

                return Convert.ToInt32(result);
            }
        }

        //método 7: actualizar receta
        public bool Update(Receta receta)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    update Recetas
                    set Titulo = @titulo,
                        Descripcion = @descripcion,
                        Ingredientes = @ingredientes,
                        Pasos = @pasos,
                        Categoria = @categoria,
                        DireccionImagen = @direccionImagen
                    where RecetaId = @recetaId
                    and UsuarioId = @usuarioId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@recetaId", receta.RecetaId);
                command.Parameters.AddWithValue("@usuarioId", receta.UsuarioId);
                command.Parameters.AddWithValue("@titulo", receta.Titulo);
                command.Parameters.AddWithValue("@descripcion", receta.Descripcion);
                command.Parameters.AddWithValue("@ingredientes", receta.Ingredientes);
                command.Parameters.AddWithValue("@pasos", receta.Pasos);
                command.Parameters.AddWithValue("@categoria", receta.Categoria);
                command.Parameters.AddWithValue("@direccionImagen", receta.DireccionImagen ?? (object)DBNull.Value);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        //método 8: eliminar receta
        public bool Delete(int recetaId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "delete from Recetas where RecetaId = @recetaId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@recetaId", recetaId);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        //método 9: incrementar vistas
        public void IncrementarVistas(int recetaId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "update Recetas set Vistas = Vistas + 1 where RecetaId = @recetaId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@recetaId", recetaId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}