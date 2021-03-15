namespace FatecMauaJobNewsletter.Domains.Models
{
    public class User : BaseEntity
    {
        public string Login { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public byte[] Password { get; set; }
    }
}
