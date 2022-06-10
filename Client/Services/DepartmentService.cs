using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using TestDeeplay.Shared.Models.Department;
using TestDeeplay.Shared.Models.Employee;
using TestDeeplay.Shared.Models.Post;

namespace TestDeeplay.Client.Services
{
    public class DepartmentService
    {
        private readonly HttpClient _httpClient;
        public DepartmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<DepartmentReadDto>> Get()
        {
            return await _httpClient.GetFromJsonAsync<List<DepartmentReadDto>>($"api/department");
        }
        public async Task<List<EmployeeReadDto>> GetEmployees(int id)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            options.PropertyNameCaseInsensitive = true;
            return await _httpClient.GetFromJsonAsync<List<EmployeeReadDto>>($"api/department/{id}", options);
        }
        
    }
}
