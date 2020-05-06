using Beceps.Utilities.AutomaticDependencyInjection;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Beceps
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDependencies();
            services.AddBlazoredLocalStorage();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
