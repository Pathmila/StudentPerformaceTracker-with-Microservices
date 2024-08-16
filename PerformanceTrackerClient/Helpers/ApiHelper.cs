using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;


namespace PerformanceTrackerClient.Helpers
{
    public class ApiHelper
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        static ApiHelper()
        {
            _httpClient.BaseAddress = new Uri("https://studentmanagement20240721180238.azurewebsites.net");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<HttpResponseMessage> PostAsync(string path, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return await _httpClient.PostAsync(path, content);
        }

        public static async Task<HttpResponseMessage> GetAsync(string path)
        {
            return await _httpClient.GetAsync(path);
        }
    }
}
