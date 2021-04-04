using FatecMauaJobNewsletter.Domains.Models.Request;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services.Interfaces
{
    public interface ISignUpService
    {
        Task<string> SignUpStudent(SignUpRequest request);

        Task<string> SignUpAdmin(SignUpRequest request);
    }
}
