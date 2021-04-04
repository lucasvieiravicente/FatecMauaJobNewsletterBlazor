using FatecMauaJobNewsletter.Domains.Consts;
using FatecMauaJobNewsletter.Domains.Models.Pages;
using FatecMauaJobNewsletter.Domains.Utils;
using FatecMauaJobNewsletter.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services
{
    public class CookieService : BaseService, ICookieService
    {
        public async Task<UserLogged> VerifyToken()
        {
            var response = await _httpClient.Get($"{_apiUrl}/Cookies/VerifyToken");

            if (response.IsSuccessStatusCode)
            {
                var userLogged = await response.Content.FormatContentTo<UserLogged>();
                
                if (!string.IsNullOrEmpty(userLogged.JwtToken))
                    HttpUtils.JwtToken = userLogged.JwtToken;

                return userLogged;
            }
            else
            {
                throw new Exception(ErrorMessages.RequestError);
            }
        }

        public string DeleteToken()
        {
            HttpUtils.JwtToken = "";
            return Messages.RequestSuccess;
        }
    }
}
