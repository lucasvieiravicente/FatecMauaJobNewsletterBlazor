using FatecMauaJobNewsletter.Domains.Models.Pages;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services.Interfaces
{
    public interface IPagesService
    {
        Task<State[]> GetStatesAsync();

        Task<City[]> GetCitiesPerStateIdAsync(string stateId);

        Task<Address> GetNeighborhoodPerZipCodeAsync(string zipCode);
    }
}
