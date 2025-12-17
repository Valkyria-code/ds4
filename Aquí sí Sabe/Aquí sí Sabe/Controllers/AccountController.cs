using Aquí_sí_Sabe.Models;
using Aquí_sí_Sabe.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aquí_sí_Sabe.Controllers
{
    public class AccountController : Controller
    {
        private readonly AuthService _authService;
        private readonly UsuarioService _usuarioService;

        public AccountController()
        {
            _authService = new AuthService();
            _usuarioService = new UsuarioService();
        }

        // LOGIN (GET)
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // LOGIN (POST)
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.Error = "Por favor completa todos los campos";
                return View();
            }

            Usuario usuario = _authService.Login(email, password);

            if (usuario == null)
            {
                ViewBag.Error = "Email o contraseña incorrectos";
                return View();
            }

            // Guardar en sesión
            Session["UserId"] = usuario.UsuarioId;
            Session["Username"] = usuario.NombreUsuario;
            Session["Email"] = usuario.Email;

            return RedirectToAction("Index", "Home");
        }

        // REGISTER (GET)
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // REGISTER (POST)
        [HttpPost]
        public ActionResult Register(string username, string email, string password, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                ViewBag.Error = "Por favor completa todos los campos";
                return View();
            }

            if (!email.Contains("@"))
            {
                ViewBag.Error = "Email inválido";
                return View();
            }

            if (password.Length < 6)
            {
                ViewBag.Error = "La contraseña debe tener al menos 6 caracteres";
                return View();
            }

            if (password != confirmPassword)
            {
                ViewBag.Error = "Las contraseñas no coinciden";
                return View();
            }

            Usuario usuario = _authService.Registrar(username, email, password);

            if (usuario == null)
            {
                ViewBag.Error = "El usuario o email ya existe";
                return View();
            }

            ViewBag.Success = "¡Cuenta creada exitosamente! Redirigiendo...";
            return RedirectToAction("Login");
        }

        // LOGOUT
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

        // PERFIL (GET)
        [HttpGet]
        public ActionResult Perfil()
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login");
            }

            int userId = (int)Session["UserId"];
            Usuario usuario = _usuarioService.GetUsuarioById(userId);

            return View(usuario);
        }

        // PERFIL (POST)
        [HttpPost]
        public ActionResult Perfil(Usuario usuario)
        {
            if (Session["UserId"] == null)
            {
                return RedirectToAction("Login");
            }

            int userId = (int)Session["UserId"];
            usuario.UsuarioId = userId;

            bool success = _usuarioService.UpdateProfile(usuario);

            if (success)
            {
                Session["Username"] = usuario.NombreUsuario;
                Session["Email"] = usuario.Email;
                ViewBag.Success = "Perfil actualizado correctamente";
            }
            else
            {
                ViewBag.Error = "Error al actualizar el perfil";
            }

            return View(usuario);
        }
    }
}