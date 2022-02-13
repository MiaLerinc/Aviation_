using DomainModel.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AviationBlazorServer.Services
{
    public class CountryService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44321/api/Country";
        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Country>> GetCountries()
        {
            return await _httpClient.GetFromJsonAsync<List<Country>>(BaseApiUrl);
        }
        public async Task AddCountryAsync(Country country)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(country), Encoding.UTF8,
            "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task<Country> GetCountryAsync(int countryId)
        {
            return await _httpClient.GetFromJsonAsync<Country>($"{BaseApiUrl}/{countryId}");
        }
        public async Task UpdateCountryAsync(Country country)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(country), Encoding.UTF8,
            "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task DeleteCountryAsync(int countryId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, $"{BaseApiUrl}/{countryId}");
            await _httpClient.SendAsync(httpRequest);
        }
    }
}
