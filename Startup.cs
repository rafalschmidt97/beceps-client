using Beceps.Utilities.AutomaticDependencyInjection;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Beceps
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            string fileName = "Beceps.wwwroot.appsettings.json";
            var stream = Assembly.GetExecutingAssembly()
                                 .GetManifestResourceStream(fileName);

            var config = new ConfigurationBuilder()
                    .AddJsonStream(stream)
                    .Build();
            services.AddSingleton<IConfiguration>(config);
            services.AddDependencies();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
