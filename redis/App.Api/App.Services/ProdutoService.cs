using App.Models.Entities;
using App.Repositories.Interfaces;
using App.Services.Interfaces;

namespace App.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService( IProdutoRepository repository )
        {
            _repository = repository;
        }
        public void AddProduto(Produto produto)
        {
            _repository.AddProdutoOrUpdate(produto);
        }

        public Produto GetProduto(string codigo)
        {
            return _repository.GetProduto(codigo);
        }

        public void RemoveProduto(string codigo)
        {
            _repository.DeleteProduto(codigo);
        }
    }
}
