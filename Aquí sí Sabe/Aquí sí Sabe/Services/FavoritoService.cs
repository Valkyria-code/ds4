using Aquí_sí_Sabe.Models;
using Aquí_sí_Sabe.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Services
{
    public class FavoritoService
    {
        private readonly FavoritoRepositorio _favoritoRepositorio;

        public FavoritoService()
        {
            _favoritoRepositorio = new FavoritoRepositorio();
        }

        //método 1: obtener recetas favoritas de un usuario
        public List<Receta> GetFavoritosUsuario(int usuarioId)
        {
            return _favoritoRepositorio.GetRecetasByUsuarioId(usuarioId);
        }

        //método 2: agregar receta a favoritos
        public bool AddToFavoritos(int usuarioId, int recetaId)
        {
            if (_favoritoRepositorio.EsFavorito(usuarioId, recetaId))
                return false;

            return _favoritoRepositorio.Insert(usuarioId, recetaId);
        }

        //método 3: quitar receta de favoritos
        public bool QuitarDeFavoritos(int usuarioId, int recetaId)
        {
            return _favoritoRepositorio.Delete(usuarioId, recetaId);
        }

        //método 4: verificar si una receta es favorita
        public bool EsFavorito(int usuarioId, int recetaId)
        {
            return _favoritoRepositorio.EsFavorito(usuarioId, recetaId);
        }
    }
}