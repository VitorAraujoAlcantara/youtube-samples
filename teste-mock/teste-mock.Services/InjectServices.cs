using Microsoft.Extensions.DependencyInjection;
using teste_mock.Services.Interfaces;

namespace teste_mock.Services
{
    public static class InjectServices
    {
        public static void AddServices(this IServiceCollection service)
        {
            service.AddTransient<IProdutoService, ProdutoService>();
        }
    }
}
