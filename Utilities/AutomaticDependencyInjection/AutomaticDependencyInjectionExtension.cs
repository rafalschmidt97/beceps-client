using Microsoft.Extensions.DependencyInjection;
using System;

namespace Beceps.Utilities.AutomaticDependencyInjection
{
    public static class AutomaticDependencyInjectionExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            services.Scan(scan => scan
                .FromAssemblies(assemblies)
                .AddClasses(classes => classes.AssignableTo<ITransient>())
                .AsSelfWithInterfaces()
                .WithTransientLifetime()
                .AddClasses(classes => classes.AssignableTo<IScoped>())
                .AsSelfWithInterfaces()
                .WithScopedLifetime()
                .AddClasses(classes => classes.AssignableTo<ISingleton>())
                .AsImplementedInterfaces()
                .AsSelfWithInterfaces()
                .WithSingletonLifetime());
        }
    }
}
