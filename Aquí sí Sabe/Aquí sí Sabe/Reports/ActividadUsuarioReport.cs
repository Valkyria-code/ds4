using Aquí_sí_Sabe.Models;
using Aquí_sí_Sabe.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aquí_sí_Sabe.Reportes
{
    public class ActividadUsuarioReport
    {
        private readonly RecetaRepositorio _recetaRepositorio;
        private readonly FavoritoRepositorio _favoritoRepositorio;
        private readonly VistaRecetaRepositorio _vistaRecetaRepositorio;

        public ActividadUsuarioReport()
        {
            _recetaRepositorio = new RecetaRepositorio();
            _favoritoRepositorio = new FavoritoRepositorio();
            _vistaRecetaRepositorio = new VistaRecetaRepositorio();
        }

        // Generar reporte de actividad de un usuario
        public ReporteActividadUsuario Generate(int usuarioId)
        {
            // Paso 1: Total de recetas creadas
            List<Receta> recetasDelUsuario = _recetaRepositorio.GetByUsuarioId(usuarioId);
            int totalRecetasCreadas = recetasDelUsuario.Count;

            // Paso 2: Total de favoritos guardados
            List<Receta> favoritosDelUsuario = _favoritoRepositorio.GetRecetasByUsuarioId(usuarioId);
            int totalRecetasFavoritas = favoritosDelUsuario.Count;

            // Paso 3: Categoría más usada
            string categoriaMasUsada = "";

            if (recetasDelUsuario.Count > 0)
            {
                var grupos = recetasDelUsuario.GroupBy(r => r.Categoria);
                var grupoMayor = grupos.OrderByDescending(g => g.Count()).FirstOrDefault();

                if (grupoMayor != null)
                {
                    categoriaMasUsada = grupoMayor.Key;
                }
            }

            // Paso 4: Últimas 5 recetas vistas (CORREGIDO nombre del método)
            List<Receta> ultimasRecetasVistas = _vistaRecetaRepositorio.GetRecentByUsuarioId(usuarioId, 5);
            List<string> titulosRecetasVistas = ultimasRecetasVistas.Select(r => r.Titulo).ToList();

            // Paso 5: Crear objeto reporte
            ReporteActividadUsuario reporte = new ReporteActividadUsuario
            {
                TotalRecetasCreadas = totalRecetasCreadas,
                TotalRecetasFavoritas = totalRecetasFavoritas,
                CategoriaMasUsada = categoriaMasUsada,
                UltimasRecetasVistas = titulosRecetasVistas
            };

            return reporte;
        }
    }
}