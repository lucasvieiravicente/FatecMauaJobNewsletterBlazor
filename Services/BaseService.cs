using System.Net.Http;

namespace FatecMauaJobNewsletter.Services
{
    public abstract class BaseService
    {
        protected readonly HttpClient _httpClient;
        protected const string _apiUrl = "https://localhost:44347";//"https://fatecmauajobnewsletterapi.azurewebsites.net";

        public BaseService()
        {
            _httpClient = new HttpClient();
        }
    }
}
