using FatecMauaJobNewsletter.Services;
using FatecMauaJobNewsletter.Services.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace FatecMauaJobNewsletter.Domains
{
    public static class InjectionConfiguration
    {
        public static void InjectServices(this WebAssemblyHostBuilder builder)
        {
            builder.Services.AddTransient<ILoginService, LoginService>();
        }
    }
}
