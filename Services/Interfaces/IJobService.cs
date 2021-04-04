using FatecMauaJobNewsletter.Domains.Models;
using FatecMauaJobNewsletter.Domains.Models.Pagination;
using FatecMauaJobNewsletter.Domains.Models.Request;
using FatecMauaJobNewsletter.Domains.Models.Response;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services.Interfaces
{
    public interface IJobService
    {
        Task<string> RegisterJob(JobVacancyRequest request);
        
        Task<JobVacancy> GetJobPerId(string jobId);

        Task<PaginationResponse<JobVacancy>> GetHomeJobs(PaginationRequest request);

        Task<PaginationResponse<JobResume>> GetAprovedJobsResumes(PaginationRequest request);

        Task<PaginationResponse<JobResume>> GetPendingJobsResumes(PaginationRequest request);

        Task<PaginationResponse<JobResume>> GetUserAprovedPaginatedJobs(PaginationRequest request);

        Task<PaginationResponse<JobResume>> GetUserReprovedPaginatedJobs(PaginationRequest request);
    }
}
