using System.Net.Http.Json;
using TestDeeplay.Shared.Models.Employee;

namespace TestDeeplay.Client.Services
{
    public class EmployeeService
    {
        private readonly HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<EmployeeReadDto>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<EmployeeReadDto>>($"api/employee");
        }
        public async Task<EmployeeReadDto> GetSpecific(int id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeReadDto>($"api/employee/{id}");
        }
    }
}
