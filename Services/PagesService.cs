using FatecMauaJobNewsletter.Domains.Models.Pages;
using FatecMauaJobNewsletter.Domains.Utils;
using FatecMauaJobNewsletter.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services
{
    public class PagesService : BaseService, IPagesService
    {
        public async Task<State[]> GetStatesAsync()
        {
            var response = await _httpClient.Get($"{_apiUrl}/Pages/GetStates");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.FormatContentTo<State[]>();
            }
            else
            {
                throw new Exception("Não foi possível obter os estados.");
            }
        }

        public async Task<City[]> GetCitiesPerStateIdAsync(string stateId)
        {
            var response = await _httpClient.Get($"{_apiUrl}/Pages/GetCities/{stateId}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.FormatContentTo<City[]>();
            }
            else
            {
                throw new Exception("Não foi possível obter as cidades.");
            }
        }

        public async Task<Address> GetNeighborhoodPerZipCodeAsync(string zipCode)
        {
            var response = await _httpClient.Get($"{_apiUrl}/Pages/GetNeighborhood/{zipCode}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.FormatContentTo<Address>();
            }
            else
            {
                throw new Exception("Não foi possível obter os estados.");
            }
        }
    }
}
