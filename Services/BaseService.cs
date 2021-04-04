using System.Net.Http;

namespace FatecMauaJobNewsletter.Services
{
    public abstract class BaseService
    {
        protected readonly HttpClient _httpClient;
        protected const string _apiUrl = "https://fatecmauajobnewsletterapi.azurewebsites.net";

        public BaseService()
        {
            _httpClient = new HttpClient();
        }
    }
}
