using FatecMauaJobNewsletter.Domains.Consts;
using FatecMauaJobNewsletter.Domains.Models.Request;
using FatecMauaJobNewsletter.Domains.Utils;
using FatecMauaJobNewsletter.Services.Interfaces;
using System;
using System.Net;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services
{
    public class UserService : BaseService, IUserService
    {
        public async Task<UserUpdate> GetUser()
        {
            var response = await _httpClient.Get($"{_apiUrl}/User/GetUser");

            if (response.IsSuccessStatusCode)
            {
                var loginResponse = await response.Content.FormatContentTo<UserUpdate>();
                return loginResponse;
            }
            else if(response.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new Exception("Usuário não localizado, contate o administrador do sistema.");
            }
        }

        public async Task<string> UpdateUser(UserUpdate request)
        {
            var response = await _httpClient.Post($"{_apiUrl}/User/UpdateUser", request);

            if (response.IsSuccessStatusCode)
            {
                return Messages.RequestSuccess;
            }
            else if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
            else
            {
                throw new Exception(ErrorMessages.RequestError);
            }
        }
    }
}
