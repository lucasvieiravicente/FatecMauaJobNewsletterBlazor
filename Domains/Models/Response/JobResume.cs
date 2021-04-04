namespace FatecMauaJobNewsletter.Domains.Models.Response
{
    public class JobResume : BaseEntity
    {
        public string JobName { get; set; }

        public string JobDescription { get; set; }

        public string Salary { get; set; }
    }
}
