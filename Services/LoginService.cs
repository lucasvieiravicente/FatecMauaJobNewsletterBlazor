using FatecMauaJobNewsletter.Services.Interfaces;
using System.Threading.Tasks;
using FatecMauaJobNewsletter.Domains.Models.Response;
using FatecMauaJobNewsletter.Domains.Models.Request;
using FatecMauaJobNewsletter.Domains.Utils;
using System;

namespace FatecMauaJobNewsletter.Services
{
    public class LoginService : BaseService, ILoginService
    {
        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            var response = await _httpClient.Post($"{_apiUrl}/Login", loginRequest);

            if (response.IsSuccessStatusCode)
            {
                var loginResponse = await response.Content.FormatContentTo<LoginResponse>();
                HttpUtils.JwtToken = loginResponse.JwtToken;
                return loginResponse;
            }
            else
            {
                throw new Exception("Login ou senha incorreto.");
            }
        }
    }
}
