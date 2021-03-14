using FatecMauaJobNewsletter.Domains.Models;
using FatecMauaJobNewsletter.Services.Interfaces;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text;

namespace FatecMauaJobNewsletter.Services
{
    public class LoginService : ILoginService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly string _apiUrl;

        public LoginService(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _configuration = configuration;
            _apiUrl = _configuration.GetConnectionString("Api");
        }

        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            string jsonRequest = JsonConvert.SerializeObject(loginRequest);
            var contentType = _configuration.GetSection("ContentType").GetSection("Body");
            var content = new StringContent(jsonRequest, Encoding.UTF8, contentType.Value);
            HttpResponseMessage response = await _httpClient.PostAsync(_apiUrl, content);

            LoginResponse loginResponse = null;

            if (response.IsSuccessStatusCode)
            {
                string httpResponse = await response.Content.ReadAsStringAsync();
                loginResponse = JsonConvert.DeserializeObject<LoginResponse>(httpResponse);
            }

            return loginResponse;
        }

        public Task Register(SignUpRequest signUpRequest)
        {
            throw new System.NotImplementedException();
        }
    }
}
