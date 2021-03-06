using FatecMauaJobNewsletter.Domains.Models.Request;
using FatecMauaJobNewsletter.Domains.Models.Response;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services.Interfaces
{
    public interface ILoginService
    {
        Task<LoginResponse> Login(LoginRequest loginRequest);
    }
}
