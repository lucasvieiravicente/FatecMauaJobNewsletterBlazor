﻿namespace FatecMauaJobNewsletter.Domains.Models.Pages
{
    public class UserLogged
    {
        public bool IsAdmin { get; set; }

        public bool IsLogged { get; set; }

        public string JwtToken { get; set; }
    }
}
