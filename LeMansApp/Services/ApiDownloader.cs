using System.Drawing;
using LeMansAPI.Models;
using Newtonsoft.Json;

namespace LeMansApp.Services
{
    public class ApiDownloader
    {
        private IConfiguration _config;

        public ApiDownloader(IConfiguration config)
        {
            _config = config;
        }
        public async Task<List<T>?> GetFromApi<T>(string path)
        {
            string url = _config["ApiConfig:Url"];


            HttpClient client = new HttpClient();
            Uri uri = new Uri(url);
            client.BaseAddress = uri;

            HttpResponseMessage response = await client.GetAsync(new Uri(uri, path));

            // Check if the request was successful
            if (response.IsSuccessStatusCode)
            {
                // Deserialize the JSON response into a list of driver objects
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<T>>(jsonResponse)!;
            }
            return null;
        }
    }
}
