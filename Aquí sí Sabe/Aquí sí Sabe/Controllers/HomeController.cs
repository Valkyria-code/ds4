using Aquí_sí_Sabe.Models;
using Aquí_sí_Sabe.Reportes;
using Aquí_sí_Sabe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aquí_sí_Sabe.Repositorios;

namespace Aquí_sí_Sabe.Controllers
{
    public class HomeController : Controller
    {
        private readonly RecetaRepositorio _recetaRepositorio;
        private readonly RecetaPopularReport _popularReport;

        public HomeController()
        {
            _recetaRepositorio = new RecetaRepositorio();
            _popularReport = new RecetaPopularReport();
        }

        public ActionResult Index()
        {
            // Obtener recetas populares
            List<ReporteRecetaPopular> popularData = _popularReport.Generate(8);
            List<Receta> popularRecetas = new List<Receta>();

            foreach (var item in popularData)
            {
                Receta receta = _recetaRepositorio.GetById(item.RecetaId);
                if (receta != null)
                {
                    popularRecetas.Add(receta);
                }
            }

            ViewBag.PopularRecetas = popularRecetas;

            // Obtener recetas recientes
            List<Receta> allRecetas = _recetaRepositorio.GetAll();
            ViewBag.RecentRecetas = allRecetas.Take(8).ToList();

            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}