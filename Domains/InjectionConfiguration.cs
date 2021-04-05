using FatecMauaJobNewsletter.Services;
using FatecMauaJobNewsletter.Services.AdminServices;
using FatecMauaJobNewsletter.Services.Interfaces;
using FatecMauaJobNewsletter.Services.Interfaces.AdminServices;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace FatecMauaJobNewsletter.Domains
{
    public static class InjectionConfiguration
    {
        public static void InjectServices(this WebAssemblyHostBuilder builder)
        {
            builder.Services.AddTransient<ILoginService, LoginService>();
            builder.Services.AddTransient<IJobService, JobService>();
            builder.Services.AddTransient<IPagesService, PagesService>();
            builder.Services.AddTransient<ISignUpService, SignUpService>();
            builder.Services.AddTransient<IJobAdminService, JobAdminService>();
            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<ICookieService, CookieService>();
        }
    }
}
