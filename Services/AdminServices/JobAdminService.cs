using FatecMauaJobNewsletter.Domains.Consts;
using FatecMauaJobNewsletter.Domains.Models.Request;
using FatecMauaJobNewsletter.Domains.Utils;
using FatecMauaJobNewsletter.Services.Interfaces.AdminServices;
using System;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services.AdminServices
{
    public class JobAdminService : BaseService, IJobAdminService
    {
        public async Task<string> RemoveJob(JobManagement request)
        {
            var response = await _httpClient.Post($"{_apiUrl}/JobAdministration/RemoveJob", request);

            if (response.IsSuccessStatusCode)
            {
                return Messages.RequestSuccess;
            }
            else
            {
                throw new Exception(ErrorMessages.RequestError);
            }
        }

        public async Task<string> AproveJob(JobManagement request)
        {      
            var response = await _httpClient.Post($"{_apiUrl}/JobAdministration/AproveJob", request);

            if (response.IsSuccessStatusCode)
            {
                return Messages.RequestSuccess;
            }
            else
            {
                throw new Exception(ErrorMessages.RequestError);
            }
        }

        public async Task<string> ReproveJob(JobManagement request)
        {
            var response = await _httpClient.Post($"{_apiUrl}/JobAdministration/ReproveJob", request);

            if (response.IsSuccessStatusCode)
            {
                return Messages.RequestSuccess;
            }
            else
            {
                throw new Exception(ErrorMessages.RequestError);
            }
        }
    }
}
