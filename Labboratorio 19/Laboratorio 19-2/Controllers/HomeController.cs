using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio_19_2.Controllers
{
    public class HomeController : Controller
    {
        private const string ApiBaseUrl = "https://localhost:44300";

        public async Task<ActionResult> Index()
        {
            try
            {
                var valor = await ObtenerValorPorId(2);

                ViewBag.Valor = valor;
                ViewBag.IdBuscado = 2;
                ViewBag.Mensaje = "Dato obtenido exitosamente";
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"Error al consumir el API: {ex.Message}";
            }

            return View();
        }

        private async Task<string> ObtenerValorPorId(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiBaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync($"api/values/{id}");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var valor = JsonConvert.DeserializeObject<string>(jsonResponse);
                    
                    return valor;
                }
                else
                {
                    throw new Exception($"Error en la respuesta: {response.StatusCode}");
                }
            }
        }

        public async Task<ActionResult> ObtenerPorId(int id)
        {
            try
            {
                var valor = await ObtenerValorPorId(id);

                ViewBag.Valor = valor;
                ViewBag.IdBuscado = id;
                ViewBag.Mensaje = "Dato obtenido exitosamente";
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"Error al consumir el API: {ex.Message}";
            }

            return View("Index");
        }
    }
}