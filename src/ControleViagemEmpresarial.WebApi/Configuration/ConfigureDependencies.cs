using ControleViagemEmpresarial.Application;
using ControleViagemEmpresarial.Infrastructure;
using ControleViagemEmpresarial.Presentation;

namespace ControleViagemEmpresarial.WebApi.Configuration
{
    public static class ConfigureDependencies
    {
        public static IServiceCollection AddProjectsDependencyInjection(this IServiceCollection services)
        {
            return services
                .AddApplication()
                .AddInfrasctructure()
                .AddPresentation();
        }
    }
}
