using Microsoft.Extensions.DependencyInjection;
using teste_mock.Repository.Interfaces;

namespace teste_mock.Repository
{
    public static class InjectRepositories
    {
        public static void AddRepositories(this IServiceCollection service)
        {
            service.AddTransient<IProdutoRepository, ProdutoRepository>();

        }
    }
}
