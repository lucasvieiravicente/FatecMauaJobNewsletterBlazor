using FatecMauaJobNewsletter.Domains.Models;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services.Interfaces
{
    public interface ILoginService
    {
        Task<LoginResponse> Login(LoginRequest loginRequest);

        Task Register(SignUpRequest signUpRequest);
    }
}
