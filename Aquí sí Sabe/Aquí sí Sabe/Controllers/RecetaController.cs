using Aquí_sí_Sabe.Models;
using Aquí_sí_Sabe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Aquí_sí_Sabe.Controllers
{
    public class RecetaController : Controller
    {
        private readonly RecipeService _recipeService;
        private readonly FavoritoService _favoritoService;

        public RecetaController()
        {
            _recipeService = new RecipeService();
            _favoritoService = new FavoritoService();
        }

        [HttpGet]
        public ActionResult Index(string category)
        {
            List<Receta> recetas;

            if (!string.IsNullOrEmpty(category))
            {
                recetas = _recipeService.GetRecetasByCategoria(category);
                ViewBag.SelectedCategory = category;
            }
            else
            {
                recetas = _recipeService.GetAllRecetas();
            }

            return View(recetas);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            int? userId = Session["UserId"] != null ? (int?)Session["UserId"] : null;
            Receta receta = _recipeService.GetRecetaById(id, userId);

            if (receta == null)
            {
                return HttpNotFound();
            }

            return View(receta);
        }

        [HttpGet]
        public ActionResult Create()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View(new Receta());
        }

        [HttpPost]
        public async Task<ActionResult> Create(Receta receta)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            receta.UsuarioId = (int)Session["UserId"];

            if (string.IsNullOrWhiteSpace(receta.Titulo) ||
                string.IsNullOrWhiteSpace(receta.Ingredientes) ||
                string.IsNullOrWhiteSpace(receta.Pasos))
            {
                ViewBag.Error = "Por favor completa todos los campos obligatorios";
                return View(receta);
            }

            int recetaId = await _recipeService.CrearReceta(receta);

            if (recetaId > 0)
            {
                return RedirectToAction("Details", new { id = recetaId });
            }

            ViewBag.Error = "Error al crear la receta";
            return View(receta);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            Receta receta = _recipeService.GetRecetaById(id, null);

            if (receta == null)
            {
                return HttpNotFound();
            }

            int userId = (int)Session["UserId"];
            if (receta.UsuarioId != userId)
            {
                return new HttpUnauthorizedResult();
            }

            return View(receta);
        }

        [HttpPost]
        public ActionResult Edit(Receta receta)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            int userId = (int)Session["UserId"];
            bool success = _recipeService.UpdateReceta(receta, userId);

            if (success)
            {
                return RedirectToAction("Details", new { id = receta.RecetaId });
            }

            ViewBag.Error = "Error al actualizar la receta";
            return View(receta);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            int userId = (int)Session["UserId"];
            bool success = _recipeService.DeleteReceta(id, userId);

            if (success)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Details", new { id = id });
        }

        [HttpGet]
        public ActionResult Search(string q)
        {
            if (string.IsNullOrWhiteSpace(q))
            {
                return RedirectToAction("Index");
            }

            List<Receta> recetas = _recipeService.BuscarRecetas(q);
            ViewBag.Query = q;

            return View(recetas);
        }
    }
}