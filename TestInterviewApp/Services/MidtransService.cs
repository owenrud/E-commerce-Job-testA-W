using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

public class MidtransService
{
    private readonly HttpClient _httpClient;
    private readonly string _serverKey;

    public MidtransService(IConfiguration config)
    {
        _httpClient = new HttpClient();
        _serverKey = config["Midtrans:ServerKey"];

        var byteArray = Encoding.UTF8.GetBytes(_serverKey + ":");
        _httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
    }

    public async Task<string> CreateSnapTransaction(object payload)
    {
        var json = JsonSerializer.Serialize(payload);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(
            "https://app.sandbox.midtrans.com/snap/v1/transactions", content
        );

        return await response.Content.ReadAsStringAsync();
    }
}
