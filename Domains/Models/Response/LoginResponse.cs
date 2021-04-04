namespace FatecMauaJobNewsletter.Domains.Models.Response
{
    public class LoginResponse
    {
        public bool IsAdmin { get; set; }

        public string JwtToken { get; set; }
    }
}
