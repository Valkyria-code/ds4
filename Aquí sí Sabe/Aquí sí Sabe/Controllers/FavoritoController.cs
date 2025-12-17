using Aquí_sí_Sabe.Models;
using Aquí_sí_Sabe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aquí_sí_Sabe.Controllers
{
    public class FavoritoController : Controller
    {
        private readonly FavoritoService _favoritoService;

        public FavoritoController()
        {
            _favoritoService = new FavoritoService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            int userId = (int)Session["UserId"];
            List<Receta> favoritos = _favoritoService.GetFavoritosUsuario(userId);

            return View(favoritos);
        }

        [HttpPost]
        public ActionResult Add(int recetaId)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            int userId = (int)Session["UserId"];
            _favoritoService.AddToFavoritos(userId, recetaId);

            return RedirectToAction("Details", "Receta", new { id = recetaId });
        }

        [HttpPost]
        public ActionResult Remove(int recetaId)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            int userId = (int)Session["UserId"];
            _favoritoService.QuitarDeFavoritos(userId, recetaId);

            return RedirectToAction("Details", "Receta", new { id = recetaId });
        }
    }
}