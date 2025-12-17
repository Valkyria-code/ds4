using Aquí_sí_Sabe.Models;
using Aquí_sí_Sabe.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Reportes
{
    public class TopFavoritesReport
    {
        private readonly RecetaRepositorio _recetaRepositorio;
        private readonly FavoritoRepositorio _favoritoRepositorio;

        public TopFavoritesReport()
        {
            _recetaRepositorio = new RecetaRepositorio();
            _favoritoRepositorio = new FavoritoRepositorio();
        }

        // Generar reporte de recetas con más favoritos
        public List<ReporteRecetaPopular> Generate(int topN)
        {
            // Obtener todas las recetas
            List<Receta> recetas = _recetaRepositorio.GetAll();

            // Crear lista de reporte
            List<ReporteRecetaPopular> reporte = new List<ReporteRecetaPopular>();

            // Por cada receta, obtener favoritos
            foreach (Receta receta in recetas)
            {
                int conteoFavoritos = _favoritoRepositorio.GetConteoFavorito(receta.RecetaId);

                ReporteRecetaPopular item = new ReporteRecetaPopular
                {
                    RecetaId = receta.RecetaId,
                    Titulo = receta.Titulo,
                    Vistas = receta.Vistas,
                    ContadorFavoritos = conteoFavoritos
                };

                reporte.Add(item);
            }

            // Ordenar por contador de favoritos descendente
            reporte = reporte.OrderByDescending(x => x.ContadorFavoritos).ToList();

            // Tomar solo los primeros N
            reporte = reporte.Take(topN).ToList();

            return reporte;
        }
    }
}