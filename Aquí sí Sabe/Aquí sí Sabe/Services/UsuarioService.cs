using Aquí_sí_Sabe.Models;
using Aquí_sí_Sabe.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public UsuarioService()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }

        //método 1: obtener usuario por ID
        public Usuario GetUsuarioById(int usuarioId)
        {
            return _usuarioRepositorio.GetById(usuarioId);
        }

        //método 2: actualizar perfil de usuario
        public bool UpdateProfile(Usuario usuario)
        {
            // Validaciones básicas
            if (usuario == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(usuario.Email) || !usuario.Email.Contains("@"))
            {
                return false;
            }

            // Verificar si el email ya está en uso por otro usuario
            Usuario usuarioConMismoEmail = _usuarioRepositorio.GetByEmail(usuario.Email);

            if (usuarioConMismoEmail != null && usuarioConMismoEmail.UsuarioId != usuario.UsuarioId)
            {
                return false;
            }

            // Actualizar usuario
            return _usuarioRepositorio.Update(usuario);
        }

        //método 3: eliminar cuenta de usuario
        public bool DeleteAccount(int usuarioId)
        {
            return _usuarioRepositorio.Delete(usuarioId);
        }
    }
}