using FatecMauaJobNewsletter.Domains.Models.Pages;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services.Interfaces
{
    public interface ICookieService
    {
        Task<UserLogged> VerifyToken();

        string DeleteToken();
    }
}
