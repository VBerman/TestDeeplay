using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using TestDeeplay.Shared.Models.Employee;
using TestDeeplay.Shared.Models.Post;

namespace TestDeeplay.Client.Services
{
    public class PostService
    {
        private readonly HttpClient _httpClient;
        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<PostShortReadDto>> GetShort()
        {
            return await _httpClient.GetFromJsonAsync<List<PostShortReadDto>>($"api/post/getshort");
        }
        public async Task<List<EmployeeReadDto>> GetEmployees(int id)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new JsonStringEnumConverter());
            options.PropertyNameCaseInsensitive = true;
            return await _httpClient.GetFromJsonAsync<List<EmployeeReadDto>>($"api/post/getemployees/{id}", options);
        }
      
    }
}
