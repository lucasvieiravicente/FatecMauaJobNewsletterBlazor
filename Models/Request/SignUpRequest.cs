namespace FatecMauaJobNewsletter.Domains.Models
{
    public class SignUpRequest
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
