using Microsoft.Extensions.DependencyInjection;
using teste.services.Interfaces;

namespace teste.services
{
    public static class ServiceExtension
    {
        public static void InjetaServicos(this IServiceCollection service)
        {
            service.AddTransient<ICalculadora, Calculadora>();
        }
    }
}
