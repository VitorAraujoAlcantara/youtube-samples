using System.Runtime.CompilerServices;
using teste_mock.Models.Entities;
using teste_mock.Repository.Interfaces;
using teste_mock.Services.Interfaces;

[assembly: InternalsVisibleTo("teste-mock.Tests")]
namespace teste_mock.Services
{
    internal class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public Produto AddProduto(int id, string nome, string codigo)
        {
           return  _repository.AddProduto(id, nome, codigo);            
        }
    }
}
