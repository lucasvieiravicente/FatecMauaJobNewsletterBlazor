using FatecMauaJobNewsletter.Domains.Models.Request;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services.Interfaces.AdminServices
{
    public interface IJobAdminService
    {
        Task<string> RemoveJob(JobManagement request);

        Task<string> AproveJob(JobManagement request);

        Task<string> ReproveJob(JobManagement request);
    }
}
