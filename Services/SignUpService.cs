using FatecMauaJobNewsletter.Domains.Consts;
using FatecMauaJobNewsletter.Domains.Models.Request;
using FatecMauaJobNewsletter.Domains.Utils;
using FatecMauaJobNewsletter.Services.Interfaces;
using System;
using System.Net;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services
{
    public class SignUpService : BaseService, ISignUpService
    {
        public async Task<string> SignUpStudent(SignUpRequest request)
        {
            var response = await _httpClient.Post($"{_apiUrl}/SignUpStudent", request);

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

        public async Task<string> SignUpAdmin(SignUpRequest request)
        {
            var response = await _httpClient.Post($"{_apiUrl}/SignUpAdmin", request);

            if (response.IsSuccessStatusCode)
            {
                return Messages.RequestSuccess;
            }
            else if(response.StatusCode == HttpStatusCode.BadRequest)
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
