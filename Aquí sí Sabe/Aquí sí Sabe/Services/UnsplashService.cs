using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Aquí_sí_Sabe.Services
{
    // Clase auxiliar para caché
    public class CachedImage
    {
        public string ImageUrl { get; set; }
        public DateTime CachedAt { get; set; }
    }

    public class UnsplashService
    {
        private readonly string _accessKey;

        // Caché compartido entre todas las instancias
        private static Dictionary<string, CachedImage> _cache = new Dictionary<string, CachedImage>();

        public UnsplashService()
        {
            _accessKey = ConfigurationManager.AppSettings["UnsplashAccessKey"];
        }

        public async System.Threading.Tasks.Task<string> GetImageUrl(string searchTerm)
        {
            // Paso 1: Normalizar término de búsqueda
            string key = searchTerm.ToLower();

            // Paso 2: Verificar caché
            if (_cache.ContainsKey(key))
            {
                CachedImage cachedImage = _cache[key];
                TimeSpan tiempoEnCache = DateTime.Now - cachedImage.CachedAt;

                if (tiempoEnCache < TimeSpan.FromHours(2))
                {
                    return cachedImage.ImageUrl;
                }
            }

            // Paso 3: Hacer request a Unsplash
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://api.unsplash.com/search/photos?query={key}&client_id={_accessKey}&per_page=1";

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (!response.IsSuccessStatusCode)
                    {
                        return "https://via.placeholder.com/400x300?text=Receta";
                    }

                    string json = await response.Content.ReadAsStringAsync();

                    // Paso 4: Parsear JSON
                    JObject data = JObject.Parse(json);

                    string imageUrl =
                        data["results"]?[0]?["urls"]?["regular"]?.ToString();

                    if (string.IsNullOrEmpty(imageUrl))
                    {
                        return "https://via.placeholder.com/400x300?text=Receta";
                    }

                    // Paso 5: Guardar en caché
                    CachedImage newCachedImage = new CachedImage
                    {
                        ImageUrl = imageUrl,
                        CachedAt = DateTime.Now
                    };

                    _cache[key] = newCachedImage;

                    return imageUrl;
                }
            }
            catch
            {
                // Paso 6: Manejo de errores
                return "https://via.placeholder.com/400x300?text=Receta";
            }
        }
    }
}