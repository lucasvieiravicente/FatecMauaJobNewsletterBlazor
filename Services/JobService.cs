using FatecMauaJobNewsletter.Domains.Consts;
using FatecMauaJobNewsletter.Domains.Models;
using FatecMauaJobNewsletter.Domains.Models.Pagination;
using FatecMauaJobNewsletter.Domains.Models.Request;
using FatecMauaJobNewsletter.Domains.Models.Response;
using FatecMauaJobNewsletter.Domains.Utils;
using FatecMauaJobNewsletter.Services.Interfaces;
using Mapster;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FatecMauaJobNewsletter.Services
{
    public class JobService : BaseService, IJobService
    {
        public async Task<string> RegisterJob(JobVacancyRequest request)
        {
            var response = await _httpClient.Post($"{_apiUrl}/JobVacancy", request);

            if (response.IsSuccessStatusCode)
            {
                return Messages.RequestSuccess;
            }
            else
            {
                throw new Exception(ErrorMessages.RequestError);
            }
        }

        public async Task<PaginationResponse<JobVacancy>> GetHomeJobs(PaginationRequest request)
        {
            var response = await _httpClient.Post($"{_apiUrl}/JobVacancy/PaginatedAprovedJobResumes", request);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.FormatContentTo<PaginationResponse<JobVacancy>>();
            }
            else
            {
                throw new Exception(ErrorMessages.RequestError);
            }
        }

        public async Task<PaginationResponse<JobResume>> GetAprovedJobsResumes(PaginationRequest request)
        {
            var response = await GetHomeJobs(request);
            var jobResumes = response.Data.Adapt<IEnumerable<JobResume>>();
            return new PaginationResponse<JobResume>(response.Page, response.PageSize, response.TotalPages, jobResumes);
        }

        public async Task<PaginationResponse<JobResume>> GetPendingJobsResumes(PaginationRequest request)
        {
            var response = await _httpClient.Post($"{_apiUrl}/JobAdministration/PaginatedJobResumes", request);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.FormatContentTo<PaginationResponse<JobResume>>();
            }
            else
            {
                throw new Exception(ErrorMessages.RequestError);
            }
        }

        public async Task<JobVacancy> GetJobPerId(string jobId)
        {
            var response = await _httpClient.Get($"{_apiUrl}/JobVacancy/{jobId}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.FormatContentTo<JobVacancy>();
            }
            else
            {
                throw new Exception(ErrorMessages.JobRequestError);
            }
        }

        public async Task<PaginationResponse<JobResume>> GetUserAprovedPaginatedJobs(PaginationRequest request)
        {
            var response = await _httpClient.Post($"{_apiUrl}/JobVacancy/PaginatedUserAprovedJobResumes", request);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.FormatContentTo<PaginationResponse<JobVacancy>>();
                var resumes = content.Data.Adapt<IEnumerable<JobResume>>();
                return new PaginationResponse<JobResume>(content.Page, content.PageSize, content.TotalPages, resumes);
            }
            else
            {
                throw new Exception(ErrorMessages.RequestError);
            }
        }

        public async Task<PaginationResponse<JobResume>> GetUserReprovedPaginatedJobs(PaginationRequest request)
        {
            var response = await _httpClient.Post($"{_apiUrl}/JobVacancy/PaginatedUserReprovedJobResumes", request);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.FormatContentTo<PaginationResponse<JobVacancy>>();
                var resumes = content.Data.Adapt<IEnumerable<JobResume>>();
                return new PaginationResponse<JobResume>(content.Page, content.PageSize, content.TotalPages, resumes);
            }
            else
            {
                throw new Exception(ErrorMessages.RequestError);
            }
        }
    }
}
