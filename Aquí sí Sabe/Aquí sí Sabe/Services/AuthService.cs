using Aquí_sí_Sabe.Models;
using Aquí_sí_Sabe.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Aquí_sí_Sabe.Services
{
    public class AuthService
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public AuthService()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }

        //método 1: hashear contraseña
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hash)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        //método 2: verificar contraseña
        private bool VerificarPassword(string password, string storedHash)
        {
            string hashedPassword = HashPassword(password);
            return hashedPassword == storedHash;
        }

        //método 3: registrar usuario
        public Usuario Registrar(string username, string email, string password)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(username))
                return null;

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                return null;

            if (string.IsNullOrWhiteSpace(password))
                return null;

            // Verificar duplicados
            if (_usuarioRepositorio.GetByEmail(email) != null)
                return null;

            if (_usuarioRepositorio.GetByNombreUsuario(username) != null)
                return null;

            Usuario usuario = new Usuario
            {
                NombreUsuario = username,
                Email = email,
                PasswordHash = HashPassword(password),
                FechaRegistro = DateTime.Now
            };

            int id = _usuarioRepositorio.Insert(usuario);

            if (id <= 0)
                return null;

            usuario.UsuarioId = id;
            return usuario;
        }

        //método 4: Login
        public Usuario Login(string email, string password)
        {
            Usuario usuario = _usuarioRepositorio.GetByEmail(email);

            if (usuario == null)
                return null;

            if (!VerificarPassword(password, usuario.PasswordHash))
                return null;

            return usuario;
        }
    }
}