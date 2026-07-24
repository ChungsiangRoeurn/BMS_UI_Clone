using BMS_Clone.Models;
using BMS_Clone.ViewModels;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Windows;

namespace BMS_Clone.Services;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://dummyjson.com")
        };
    }

    public async Task<List<UserModel>> GetUsersAsync()
    {
        var json = await _httpClient.GetStringAsync("/users");

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var response = JsonSerializer.Deserialize<UserResponse>(json, options);

        return response?.Users ?? new();
    }

    public async Task<List<ProductModel>> GetProductsAsync()
    {
        var res = await _httpClient.GetFromJsonAsync<ProductResponse>("products");

        return res?.Products ?? new List<ProductModel> ();
    }

    public async Task<List<ProductModel>> SearchProductAsync(string keyword)
    {
        var res = await _httpClient.GetFromJsonAsync<ProductResponse>(
                $"products/search?q={keyword}"
            );

        return res?.Products ?? new();
    }

    public async Task<LoginResponse?> LoginAsync(LoginRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync("auth/login", request);

        if (!response.IsSuccessStatusCode)
            return null;

        return await response.Content.ReadFromJsonAsync<LoginResponse>();
    }
}