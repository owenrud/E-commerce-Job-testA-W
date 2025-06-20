using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace TestInterviewApp.api
{
    public class MidtransService
    {
        private readonly HttpClient _http;
        private readonly string _serverKey, _baseUrl;
        public MidtransService(HttpClient http, IConfiguration cfg)
        {
            _http = http;
            _serverKey = cfg["Midtrans:ServerKey"];
            _baseUrl = cfg["Midtrans:BaseUrl"];
        }
        public async Task<string> CreateSnapTransaction(object payload)
        {
            var url = $"{_baseUrl}/snap/v1/transactions";
            var req = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json")
            };
            var token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_serverKey}:"));
            req.Headers.Authorization = new AuthenticationHeaderValue("Basic", token);

            var resp = await _http.SendAsync(req);
            resp.EnsureSuccessStatusCode();
            return await resp.Content.ReadAsStringAsync();
        }
    }
      
    }
