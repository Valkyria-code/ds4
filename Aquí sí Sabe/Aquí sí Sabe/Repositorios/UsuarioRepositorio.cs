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
    public class UsuarioRepositorio
    {
        //método 1: Obtener usuario por ID
        public Usuario GetById(int usuarioId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "select * from Usuarios where UsuarioId = @usuarioId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioId", usuarioId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return UsuarioMapper.Map(reader);
                    }
                }
            }
            return null;
        }

        //método 2: Obtener usuario por Email (Login)
        public Usuario GetByEmail(string email)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "select * from Usuarios where Email = @email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return UsuarioMapper.Map(reader);
                    }
                }
            }
            return null;
        }

        //método 3: Obtener usuario por Username
        public Usuario GetByNombreUsuario(string nombreUsuario)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "select * from Usuarios where NombreUsuario = @nombreusuario";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombreusuario", nombreUsuario);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return UsuarioMapper.Map(reader);
                    }
                }
            }
            return null;
        }

        //método 4: Insertar nuevo usuario
        public int Insert(Usuario usuario)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    insert into Usuarios (NombreUsuario, Email, PasswordHash, FechaRegistro)
                    values (@nombreusuario, @email, @hash, @fecha);
                    select scope_identity();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombreusuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@email", usuario.Email);
                command.Parameters.AddWithValue("@hash", usuario.PasswordHash);
                command.Parameters.AddWithValue("@fecha", usuario.FechaRegistro);

                connection.Open();
                object result = command.ExecuteScalar();

                return Convert.ToInt32(result);
            }
        }

        //método 5: Actualizar usuario (sin password)
        public bool Update(Usuario usuario)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    update Usuarios 
                    set NombreUsuario = @nombreusuario, Email = @email
                    where UsuarioId = @usuarioId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombreusuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@email", usuario.Email);
                command.Parameters.AddWithValue("@usuarioId", usuario.UsuarioId);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        //método 6: Eliminar usuario
        public bool Delete(int usuarioId)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "delete from Usuarios where UsuarioId = @usuarioId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuarioId", usuarioId);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
    }
}