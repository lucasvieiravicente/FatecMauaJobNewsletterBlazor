using FatecMauaJobNewsletter.Domains.Models.Request;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserUpdate> GetUser();

        Task<string> UpdateUser(UserUpdate request);
    }
}
