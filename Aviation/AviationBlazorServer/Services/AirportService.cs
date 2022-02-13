using DomainModel.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AviationBlazorServer.Services
{
    public class AirportService
    {
        private readonly HttpClient _httpClient;
        private readonly string BaseApiUrl = "https://localhost:44321/api/Airport";
        public AirportService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Airport>> GetAirports()
        {
            return await _httpClient.GetFromJsonAsync<List<Airport>>(BaseApiUrl);
        }
        public async Task AddAirportAsync(Airport airport)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(airport), Encoding.UTF8,
            "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task<Airport> GetAirportAsync(int airportId)
        {
            return await _httpClient.GetFromJsonAsync<Airport>($"{BaseApiUrl}/{airportId}");
        }
        public async Task UpdateAirportAsync(Airport airport)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, BaseApiUrl);
            request.Content = new StringContent(JsonSerializer.Serialize(airport), Encoding.UTF8,
            "application/json");
            await _httpClient.SendAsync(request);
        }
        public async Task DeleteAirportAsync(int airportId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, $"{BaseApiUrl}/{airportId}");
            await _httpClient.SendAsync(httpRequest);
        }
        public async Task ArchiveAirportAsync(int airportId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Put, $"{BaseApiUrl}/archiveAirport/{airportId}");
            await _httpClient.SendAsync(httpRequest);
        }
        public async Task<List<Airport>> GetArchivedAirportsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Airport>>($"{BaseApiUrl}/archivedAirports");
        }

    }
}
