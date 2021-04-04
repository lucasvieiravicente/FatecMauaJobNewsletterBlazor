using FatecMauaJobNewsletter.Domains.Models;
using FatecMauaJobNewsletter.Domains.Models.Response;
using Mapster;

namespace FatecMauaJobNewsletter.Domains.Utils
{
    public static class ConfigMapster
    {
        public static TypeAdapterConfig Configs()
        {
            var config = new TypeAdapterConfig();

            config.NewConfig<JobVacancy, JobResume>();

            return config;
        }
    }
}
