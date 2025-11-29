using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio_19_1.Controllers
{
    public class HomeController : Controller
    {
        private const string ApiBaseUrl = "https://localhost:44300";

        public async Task<ActionResult> Index()
        {
            try
            {
                var valores = await ObtnerTodoLosValores();

                ViewBag.Valores = valores;
                ViewBag.Mensaje = "Datos obtenidos exitosamente.";
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al obtener los datos: " + ex.Message;
            }

            return View();
        }

        private async Task<List<string>> ObtnerTodoLosValores()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ApiBaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("api/values");


                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var valores = JsonConvert.DeserializeObject<List<string>>(jsonResponse);
                    
                    return valores;
                }
                else
                {
                    throw new Exception("Error en la llamada a la API: " + response.StatusCode);
                }
            }
        }
    }
}