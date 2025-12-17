using Aquí_sí_Sabe.Models;
using Aquí_sí_Sabe.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Services
{
    public class RecipeService
    {
        private readonly RecetaRepositorio _recetaRepositorio;
        private readonly VistaRecetaRepositorio _recetaVistaRepositorio;
        private readonly FavoritoRepositorio _favoritoRepositorio;
        private readonly UnsplashService _unsplashService;

        public RecipeService()
        {
            _recetaRepositorio = new RecetaRepositorio();
            _recetaVistaRepositorio = new VistaRecetaRepositorio();
            _favoritoRepositorio = new FavoritoRepositorio();
            _unsplashService = new UnsplashService();
        }

        //método 1: Obtener todas las recetas
        public List<Receta> GetAllRecetas()
        {
            return _recetaRepositorio.GetAll();
        }

        //método 2: obtener receta por id + lógica adicional
        public Receta GetRecetaById(int recetaId, int? usuarioActualId)
        {
            Receta receta = _recetaRepositorio.GetById(recetaId);

            if (receta == null)
            {
                return null;
            }
                
            _recetaVistaRepositorio.Insert(usuarioActualId, recetaId);
            _recetaRepositorio.IncrementarVistas(recetaId);

            if (usuarioActualId.HasValue)
            {
                receta.EsFavorito = _favoritoRepositorio.EsFavorito(usuarioActualId.Value, recetaId);
            }

            return receta;
        }

        //método 3: buscar recetas
        public List<Receta> BuscarRecetas(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return new List<Receta>();
            }

            return _recetaRepositorio.Search(query);
        }

        //método 4: filtrar por categoría
        public List<Receta> GetRecetasByCategoria(string categoria)
        {
            return _recetaRepositorio.GetByCategoria(categoria);
        }

        //método 5: crear receta
        public async System.Threading.Tasks.Task<int> CrearReceta(Receta receta)
        {
            if (string.IsNullOrWhiteSpace(receta.Titulo) ||
                string.IsNullOrWhiteSpace(receta.Ingredientes) ||
                string.IsNullOrWhiteSpace(receta.Pasos))
            {
                return 0;
            }

            if (receta.UsuarioId <= 0)
            {
                return 0;
            }

            if (string.IsNullOrWhiteSpace(receta.DireccionImagen))
            {
                string imageUrl = await _unsplashService.GetImageUrl(receta.Titulo);
                receta.DireccionImagen = imageUrl ?? "/images/placeholder.jpg";
            }

            receta.FechaCreacion = DateTime.Now;

            return _recetaRepositorio.Insert(receta);
        }

        //método 6: actualizar receta
        public bool UpdateReceta(Receta receta, int usuarioActualId)
        {
            Receta original = _recetaRepositorio.GetById(receta.RecetaId);

            if (original == null)
            {
                return false;
            }

            if (original.UsuarioId != usuarioActualId)
            {
                return false;
            }

            return _recetaRepositorio.Update(receta);
        }

        //método 7: eliminar receta
        public bool DeleteReceta(int recetaId, int usuarioActualId)
        {
            Receta recipe = _recetaRepositorio.GetById(recetaId);

            if (recipe == null)
            {
                return false;
            }

            if (recipe.UsuarioId != usuarioActualId)
            {
                return false;
            }

            return _recetaRepositorio.Delete(recetaId);
        }

        //método 8: obtener recetas de un usuario
        public List<Receta> GetRecetasUsuario(int usuarioId)
        {
            return _recetaRepositorio.GetByUsuarioId(usuarioId);
        }
    }
}