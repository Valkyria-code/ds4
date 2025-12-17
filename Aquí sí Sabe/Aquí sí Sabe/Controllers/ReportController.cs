using Aquí_sí_Sabe.Models;
using Aquí_sí_Sabe.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aquí_sí_Sabe.Controllers
{
    public class ReportController : Controller
    {
        private readonly RecetaPopularReport _popularReport;
        private readonly TopFavoritesReport _topFavoritesReport;
        private readonly ActividadUsuarioReport _userActivityReport;

        public ReportController()
        {
            _popularReport = new RecetaPopularReport();
            _topFavoritesReport = new TopFavoritesReport();
            _userActivityReport = new ActividadUsuarioReport();
        }

        [HttpGet]
        public ActionResult Dashboard()
        {
            List<ReporteRecetaPopular> popular = _popularReport.Generate(10);
            List<ReporteRecetaPopular> topFavorites = _topFavoritesReport.Generate(10);

            ViewBag.PopularRecetas = popular;
            ViewBag.TopFavoritos = topFavorites;

            if (Session["UserId"] != null)
            {
                int userId = (int)Session["UserId"];
                ReporteActividadUsuario userActivity = _userActivityReport.Generate(userId);
                ViewBag.UserActivity = userActivity;
            }

            return View();
        }
    }
}