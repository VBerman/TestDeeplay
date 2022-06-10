using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
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
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            options.PropertyNameCaseInsensitive = true;
            return await _httpClient.GetFromJsonAsync<List<EmployeeReadDto>>($"api/employee", options);
        }
        public async Task<EmployeeReadDto> GetSpecific(int id)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            options.PropertyNameCaseInsensitive = true;
            return await _httpClient.GetFromJsonAsync<EmployeeReadDto>($"api/employee/{id}", options);
        }
        public async Task<List<EmployeeReadDto>> GetByDepartmentAndPost(int departmentId, int postId)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            options.PropertyNameCaseInsensitive = true;
            return await _httpClient.GetFromJsonAsync<List<EmployeeReadDto>>($"api/employee/{departmentId}/{postId}", options);
        }
    }
}
